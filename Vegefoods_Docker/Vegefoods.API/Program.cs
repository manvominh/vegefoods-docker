using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;
using Vegefoods.API.Extensions;
using Vegefoods.Application.Extensions;
using Vegefoods.Persistence.Extensions;
using Vegefoods.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.		
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");
builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration, dbHost, dbName, dbPassword);
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(policy =>
{
	policy.AddPolicy("CorsPolicy", opt => opt
		//.AllowAnyOrigin()
		.WithOrigins("http://localhost:3000", "http://localhost:4200")
		.AllowAnyHeader()
		.AllowAnyMethod());
});
builder.Services.AddAuthentication(o =>
{
	o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
	o.RequireHttpsMetadata = false;
	o.SaveToken = true;
	o.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuerSigningKey = true,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtAuthenticationManagerService.JWT_SECURITY_KEY)),
		ValidateIssuer = false,
		ValidateAudience = false,
		ValidateLifetime = true,
	};
});

var _loggrer = new LoggerConfiguration()
.ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext()
.CreateLogger();
builder.Logging.AddSerilog(_loggrer);

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
	app.UseSwagger();
	app.UseSwaggerUI();
//}

app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseErrorHandler();
app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();

public partial class Program { }