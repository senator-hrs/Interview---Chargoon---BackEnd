using Interview.Entities;
using Interview.Interfaces;
using System;

namespace Interview.Classes
{
	internal class TaskManager
	{
		private readonly IUserService _userService;
		private readonly ITaskService _taskService;

		public TaskManager(IUserService userService, ITaskService taskService)
		{
			_userService = userService;
			_taskService = taskService;
		}

        

        public void RunTaskManager()
		{
			

			while (true)
			{
				Helper.PrintMenu(
				"1- Insert new user.",
				"2- Insert new task.",
				"3- Show users with assigned tasks.",
				"4- Assign task to user.",
				"5- Show DataBase.",
				"0- Exit");

				Helper.PrintMessageInline("Please enter a number: ");

				int action = Convert.ToInt32(Console.ReadLine());

				Console.Clear();

				switch (action)
				{
					case 1:
						Helper.PrintMessageInline("Enter user Name:");
						string name = Console.ReadLine();
						_userService.AddNewUser(new User { Name = name });
						Console.Clear();
						Helper.PrintInfo("User added.");
						break;

					case 2:
						Helper.PrintMessageInline("Enter task title:");
						string title = Console.ReadLine();
						_taskService.AddNewTask(new Task { Title = title });
						Console.Clear();
						Helper.PrintInfo("Task added.");
						break;

					case 3:
						_userService.ShowUsersWithAssginedTasks();
						break;

					case 4:
						_userService.ShowUsersList();
						_taskService.ShowTasksList();
						Helper.PrintMessageInline("Enter userID,taskID:");
						string[] userInput = Console.ReadLine().Split(',');

						int userID = Convert.ToInt32(userInput[0]);
						int taskID = Convert.ToInt32(userInput[1]);

						User user = _userService.GetByID(userID);
						Task task = _taskService.GetByID(taskID);

						try
						{
							_userService.AssignTask(user, task);

							Console.Clear();
							Helper.PrintInfo("Task assigned to the user.");
						}
						catch (Exception ex)
						{
							Console.Clear();
							Helper.PrintError(ex.Message);
						}
						break;

					case 5:
						_userService.ShowUsersList();
						_taskService.ShowTasksList();
						break;

					case 0:
						return;
					default:
						break;
				}
			}
		}
	}
}
