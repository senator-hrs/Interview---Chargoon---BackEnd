using Interview.Entities;
using System.Collections.Generic;

namespace Interview.Interfaces
{
	interface ITaskService
	{
		List<Task> GetTasks();
		void AddNewTask(Task newTask);
		void ShowTasksList();
		Task GetByID(int entityID);
	}
}
