using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
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




            //var container = new WindsorContainer();
            //container.Register(Component.For<TaskManager>());
            //container.Register(Component.For<IUserService>()
            //    .ImplementedBy<UserService>());
            //container.Register(Component.For<ITaskService>()
            //    .ImplementedBy<TaskService>().LifestyleSingleton());

            //var client = container.Resolve<TaskManager>();
            //client.RunTaskManager();

            //container.Release(client);




            Console.ReadKey();
            //var taskManager = new TaskManager();
            //taskManager.RunTaskManager();
        }
        static ServiceProvider serviceProvider()
        {

            var services = new ServiceCollection();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient<TaskManager>();
            return services.BuildServiceProvider();
        }

    }
}
