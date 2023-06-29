using EntregaSegura.API.Extensions;
using Microsoft.AspNetCore.Mvc;
using EntregaSegura.Infra.IoC;
using EntregaSegura.Application.Mappings;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddContext(builder.Configuration);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "EntregaSegura.API",
        Version = "v1",
        Description = "API para o projeto EntregaSegura",
        Contact = new OpenApiContact
        {
            Name = "Danilo Silva",
            Email = "danilo.silva@msn.com"
        }
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header usando Bearer.
                        Entre com 'Bearer ' [espaço] então coloque seu token.
                        Exemplo: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;

});

builder.Services.AddCors(options =>
{
    options.AddPolicy("Development",
        builder =>
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

    options.AddPolicy("Production",
        builder =>
            builder
                .WithMethods("GET")
                .WithOrigins("http://localhost:5000")
                .SetIsOriginAllowedToAllowWildcardSubdomains()
                .AllowAnyHeader());
});

builder.Services.ResolveDependencies();
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Development");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();