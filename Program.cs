var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews(); // Allows support for API or views (e.g Blazor)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();  // Adds HSTS for production to enhance security by enforcing HTTPS.
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // Serves files from the wwwroot directory, which is where the React app's build folder contents should be placed after publishing.
app.UseRouting();   // Enables routing for both API endpoints and fallback routes.

// This is where the API routes are defined
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

// This is where the front-end CRA index.html is linked to the back-end - it will fallback to this for all other requests
app.MapFallbackToFile("index.html");;

app.Run();
