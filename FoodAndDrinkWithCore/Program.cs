using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index"; // Yetkisi olmayanlarýn yönlendirileceði sayfa
    });
builder.Services.AddControllersWithViews(config =>
{
	// Yeni bir yetkilendirme politikasý oluþturuyoruz
	var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser() // Kullanýcýnýn giriþ yapmýþ olmasýný zorunlu tut
					.Build();

	// Bu politikayý tüm projedeki her sayfaya (global filtre olarak) uygula
	config.Filters.Add(new AuthorizeFilter(policy));
});

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Category}/{action=Index}/{id?}");

app.Run();