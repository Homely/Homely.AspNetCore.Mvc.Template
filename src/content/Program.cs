using System.Threading.Tasks;

namespace Homely.AspNetCore.WebApi.Template
{
    public static class Program
    {
        public static Task Main(string[] args)
        {
            return Homely.AspNetCore.Hosting.CoreApp.Program.Main<Startup>(args);
        }
    }
}
