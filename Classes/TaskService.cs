using Interview.Entities;
using Interview.Interfaces;
using System;
using System.Collections.Generic;

namespace Interview.Classes
{
	internal class TaskService : ITaskService
	{

		public void AddNewTask(Task newTask)
		{
			List<Task> allTasks = GetTasks();
			if (allTasks.Count > 0)
			{
				newTask.ID = allTasks[allTasks.Count - 1].ID + 1;
			}
			else
			{
				newTask.ID = 1;
			}

			DataBase.Tasks.Add(newTask);
		}

		public Task GetByID(int entityID)
		{
			return GetTasks().Find(x => x.ID == entityID);
		}

		public List<Task> GetTasks()
		{
			return DataBase.Tasks;
		}

		public void ShowTasksList()
		{
			Helper.PrintInfo("List of tasks:");
			foreach (Task task in GetTasks())
			{
				Helper.PrintMessage($"\t{task.ID} - {task.Title} - {task.State}");
			}

			Helper.PrintSeprator();
		}
	}
}
