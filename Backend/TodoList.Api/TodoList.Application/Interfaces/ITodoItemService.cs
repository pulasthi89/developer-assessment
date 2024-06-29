using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Entities;

namespace TodoList.Application.Interfaces
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> GetAllPendingTodoItems();
        Task<TodoItem> GetTodoItem(Guid id);

       
    }
}
