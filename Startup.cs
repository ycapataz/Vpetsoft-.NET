using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using VpetsofttNet.Datos;

namespace VpetsofttNet;

public class Startup
{
    // Este método se utiliza para configurar los servicios de la aplicación.
    public void ConfigureServices(IServiceCollection services)
    {
        // Registrar la clase Conexion como un servicio
        services.AddSingleton<ConexionBD>();
    }

    // Este método se utiliza para configurar el pipeline de solicitud HTTP.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // En producción, configurar el manejo de errores de otra manera, como un middleware de página de error personalizado.
            app.UseExceptionHandler("/Home/Error");
        }

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}