using System;
using Interview.Classes;
using Interview.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceProvider container = serviceProvider())
            {
                var controller = container.GetRequiredService<TaskManager>();
                //var controller2= container.GetService<TaskManager>();
                controller.RunTaskManager();
            }



            Console.ReadKey();
            //var taskManager = new TaskManager();
            //taskManager.RunTaskManager();
        }
        static ServiceProvider serviceProvider()
        {

            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITaskService, TaskService>();
            return services.BuildServiceProvider();
        }

    }
}
