namespace Ranjitha_Rangappa_Sprint1.Models
{
    public interface ITaskRepository
    {
        List<TaskModel> GetAllTasks();
        TaskModel GetTasksById(int id);
        TaskModel AddTasks(TaskModel taskModel);
        void UpdateTasks(TaskModel taskModel);
        void DeleteTasks(int id);
    }
}
