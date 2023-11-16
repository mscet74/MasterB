using MasterBurger.Services;
using MasterBurger.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
		options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();


//Configuracao da Password
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => {
	options.Password.RequireDigit = false;
	options.Password.RequireLowercase = false;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireUppercase = false;
	options.Password.RequiredLength = 3;
})
		.AddEntityFrameworkStores<ApplicationDbContext>()
		.AddDefaultUI()
		.AddDefaultTokenProviders();



//Servicos
builder.Services.AddTransient<RoleInitializationService>();
builder.Services.AddSingleton<IEmailSender, EmailSender>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
	app.UseMigrationsEndPoint();
} else {
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}");



// Iniciar os perfis:
using (var scope = app.Services.CreateScope()) {
	var services = scope.ServiceProvider;

	try {
		var roleInitializationService = services.GetRequiredService<RoleInitializationService>();
		await roleInitializationService.InitializeRoles();
	} catch (Exception ex) {
		Console.WriteLine($"Ocorreu um erro durante a inicialização de funções. Detalhes: {ex.Message}");
	}
}
app.Run();
