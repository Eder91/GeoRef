using GeoRef;
using GeoRef.Services;
using GeoRef.Services.IServices;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IEstadosService, EstadosService>();
builder.Services.AddHttpClient<IUsuariosService, UsuariosService>();
builder.Services.AddHttpClient<IGeoReferencesService, GeoReferenceService>();

SD.EstadoAPIBase = builder.Configuration["ServiceUrls:EstadoAPI"];
SD.UserAPIBase = builder.Configuration["ServiceUrls:UserAPI"];
SD.GeoReferenceAPIBase = builder.Configuration["ServiceUrls:GeoReferenceAPI"];

builder.Services.AddScoped<IEstadosService, EstadosService>();
builder.Services.AddScoped<IUsuariosService, UsuariosService>();
builder.Services.AddScoped<IGeoReferencesService, GeoReferenceService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "oidc";
})
    .AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(10))
    .AddOpenIdConnect("oidc", options =>
    {
        options.Authority = builder.Configuration["ServiceUrls:IdentityAPI"];
        options.GetClaimsFromUserInfoEndpoint = true;
        options.ClientId = "mango";
        options.ClientSecret = "secret";
        options.ResponseType = "code";
        options.ClaimActions.MapJsonKey("role", "role", "role");
        options.ClaimActions.MapJsonKey("sub", "sub", "sub");
        options.TokenValidationParameters.NameClaimType = "name";
        options.TokenValidationParameters.RoleClaimType = "role";
        options.Scope.Add("mango");
        options.SaveTokens = true;
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
