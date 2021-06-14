using Interview.Entities;
using Interview.Interfaces;
using System;
using System.Collections.Generic;

namespace Interview.Classes
{
	internal class BaseService<T> : IBaseService<T>
	{
		private readonly List<T> collection;

		public BaseService(List<T> collection)
		{
			this.collection = collection;
		}

		public T GetByID(int entityID)
		{
			throw new NotImplementedException();
			//return collection.Find(x => x.ID == entityID);
		}
	}
}
