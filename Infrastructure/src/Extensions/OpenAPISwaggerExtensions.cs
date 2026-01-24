using Microsoft.OpenApi.Models;

namespace Infrastructure.Extensions;

public static class OpenAPISwaggerExtensions
{
    public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Nameless Bible application",
                Version = "v0.1",
                Description = """
                              # Yet Another Bible App (YABA)
                              
                              This app is a study project for me. Developing this I'm trying to re-learn things I have forgotten after going on a long pause.
                              
                              ## Key features
                              
                              - Easy access to daily devotionals in increasing amount of bible translations.
                              """,
                Contact = new OpenApiContact
                {
                    Name = "Juho Simojoki",
                    Email = "juho.simojoki@outlook.com"
                }
            });
            
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme."
            });
            
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });
        return services;
    }
}