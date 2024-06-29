using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Entities;

namespace TodoList.Application.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<List<TodoItem>> GetAllPendingTodoItems();
        Task<TodoItem?> Get(int id);
        Task Add(TodoItem item);
        Task Update(TodoItem item);
        Task Delete(int id);
    }
}
