using TodoList.Application.Interfaces;
using TodoList.Domain.Entities;

namespace TodoList.Application.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ITodoItemRepository _todoItemRepository;
        public TodoItemService(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public Task<List<TodoItem>> GetAllPendingTodoItems()
        {
            return _todoItemRepository.GetAllPendingTodoItems();
        }

        public Task<TodoItem> GetTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}