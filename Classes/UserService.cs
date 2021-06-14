using Interview.Entities;
using Interview.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Interview.Enumerations.Enums;

namespace Interview.Classes
{
	internal class UserService : IUserService
	{
		public void AddNewUser(User newUser)
		{
			List<User> allUsers = GetUsers();
			if (allUsers.Count > 0)
			{
				newUser.ID = allUsers[allUsers.Count - 1].ID + 1;
			}
			else
			{
				newUser.ID = 1;
			}

			DataBase.Users.Add(newUser);
		}

		public void AssignTask(User user, Task task)
		{
			task.State = TaskState.Assign;

			user.Tasks.Add(task);
		}

		public User GetByID(int entityID)
		{
			return GetUsers().Find(x => x.ID == entityID);
		}

		public List<User> GetUsers()
		{
			return DataBase.Users;
		}

		public void ShowUsersList()
		{
			Helper.PrintInfo("List of users:");

			foreach (User user in GetUsers())
			{
				Helper.PrintMessage($"\t{user}");
			}

			Helper.PrintSeprator();
		}

		public void ShowUsersWithAssginedTasks()
		{
			Helper.PrintInfo("List of users:");
			StringBuilder userTasks = new StringBuilder();

			foreach (User user in GetUsers())
			{
				foreach (Task task in user.Tasks)
				{
					userTasks.Append($"{task.Title}, ");
				}
				Helper.PrintMessage($"\t{user} - {userTasks}");
				userTasks.Clear();
			}
			Helper.PrintSeprator();
		}
	}
}
