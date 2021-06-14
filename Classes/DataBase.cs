using Interview.Entities;
using System.Collections.Generic;
using static Interview.Enumerations.Enums;

namespace Interview.Classes
{
	internal static class DataBase
	{
		static DataBase()
		{
			Task task1 = new Task { ID = 1, Title = "Task01", State = TaskState.Unassign };
			Task task2 = new Task { ID = 2, Title = "Task02", State = TaskState.Unassign };
			Task task3 = new Task { ID = 3, Title = "Task03", State = TaskState.Unassign };
			Task task4 = new Task { ID = 4, Title = "Task04", State = TaskState.Unassign };

			Tasks = new List<Task> { task1, task2, task3, task4 };

			User user1 = new User { ID = 1, Name = "User01" };
			User user2 = new User { ID = 2, Name = "User02" };

			Users = new List<User> { user1, user2 };
		}

		public static List<User> Users { get; set; }
		public static List<Task> Tasks { get; set; }
	}
}
