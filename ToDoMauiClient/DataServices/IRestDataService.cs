using ToDoMauiClient.Models;

namespace ToDoMauiClient.DataServices
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetAllTodosAsync();
        Task AddToDoAsync(ToDo toDo);
        Task UpdateToDoAsync(ToDo toDo);
        Task DeleteToDoAsync(int id);
    }
}
