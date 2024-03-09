using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskItem>> GetTasks();
        Task<TaskItem> GetTask(int id);
        Task<TaskItem> CreateTask(TaskItem task);
        Task<TaskItem> UpdateTask(int id, TaskItem task);
        Task DeleteTask(int id);
    }
}
