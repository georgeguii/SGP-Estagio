using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SpgEstagioTeste;
using SpgEstagioTeste.Infra;
using SpgEstagioTeste.Models.Contracts;
using SpgEstagioTeste.Models.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// Add services to the container.
services.AddCors(options =>
{
    options.AddPolicy("CorsApi",
        builder => builder.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

services.AddControllers();

var key = Encoding.ASCII.GetBytes(Settings.Secret);

services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x => {
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters{ 
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

services.AddTransient<IUserService, UserService>();

services.Configure<MongoDBOptions>(options => options
                .ConnectionStringMongo = builder.Configuration["Database:ConnectionStringMongo"]);

services.Configure<MongoDBOptions>(options => options
                .DatabaseMongo = builder.Configuration["Database:DatabaseMongo"]);

var app = builder.Build();

app.UseRouting();
app.UseCors("CorsApi");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
