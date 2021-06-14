using Interview.Entities;
using System.Collections.Generic;

namespace Interview.Interfaces
{
	interface IUserService
	{
		List<User> GetUsers();
		void AssignTask(User user, Task task);
		void AddNewUser(User newUser);
		void ShowUsersList();
		void ShowUsersWithAssginedTasks();
		User GetByID(int entityID);
	}
}
