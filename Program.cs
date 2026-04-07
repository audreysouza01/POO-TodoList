var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configuração do roteamento
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=Index}");

app.Run();