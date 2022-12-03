namespace Web.RTSU.Task.ExtensionMethods
{
    public static class AddRouteService
    {
        public static void  AddMapControllerRoute(this WebApplication app)
        {
            app.UseEndpoints(endpoints => {

                endpoints.MapControllerRoute
                (
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute
               (
                  name: "Admin",
                  pattern: "{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
