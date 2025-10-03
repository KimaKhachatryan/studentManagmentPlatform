using studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;
using studentManagmentPlatform.Service;

namespace studentManagmentPlatform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddControllers();

            builder.Services.AddScoped<ITeacherService, TeacherService>();

            app.MapControllers();
            app.Run();
        }
    }
}
