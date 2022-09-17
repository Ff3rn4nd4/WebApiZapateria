using WebApiZapateria;

//redireccionando los servicios

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices((IServiceCollection)builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
