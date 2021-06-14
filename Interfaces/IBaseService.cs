namespace Interview.Interfaces
{
	interface IBaseService<T>
	{
		T GetByID(int entityID);
	}
}
