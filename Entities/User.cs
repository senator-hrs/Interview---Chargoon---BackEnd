using System.Collections.Generic;

namespace Interview.Entities
{
	internal class User : BaseEntity
	{
		public string Name { get; set; }
		public List<Task> Tasks { get; set; } = new List<Task>();

		public override string ToString()
		{
			return $"{ID} - {Name}";
		}
	}
}
