using WebApiAutores;

var builder = WebApplication.CreateBuilder(args);

//Creada desde la clase Startup
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

//Creada desde la clase Startup
startup.Configure(app, app.Environment);

app.Run();
