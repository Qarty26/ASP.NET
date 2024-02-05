namespace Roads.Services.UnitOfWorkService
{
    public interface IUnitOfWorkService
    {
        Task SaveAllAsync();
        void SaveAll();
    }
}
