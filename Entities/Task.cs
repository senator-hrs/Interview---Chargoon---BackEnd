using static Interview.Enumerations.Enums;

namespace Interview.Entities
{
	internal class Task: BaseEntity
	{
		public Task()
		{
			State = TaskState.Unassign;
		}
		public string Title { get; set; }
		public TaskState State { get; set; }
	}
}
