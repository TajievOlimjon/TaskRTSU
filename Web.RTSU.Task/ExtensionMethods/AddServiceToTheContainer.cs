using Services.EntitiesServices.DepartmentServices;
using Services.EntitiesServices.EmployeeServices;

namespace Web.RTSU.Task.ExtensionMethods
{
    public static class AddServiceToTheContainer
    {

        public static void AddServicesToTheContainer(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService,EmployeeService>();
        }
    }
}
