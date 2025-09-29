using TaskManagerApp.Models;

namespace TaskManagerApp.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(int id);
        Task AddAsync(TaskItem item);
        void Update(TaskItem task);
        void Delete(TaskItem task);
        Task SaveChangesAsync();

    }
}
