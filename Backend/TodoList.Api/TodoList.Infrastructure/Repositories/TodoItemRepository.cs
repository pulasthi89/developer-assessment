using Microsoft.EntityFrameworkCore;
using TodoList.Application.Interfaces;
using TodoList.Domain.Entities;

namespace TodoList.Infrastructure.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly TodoContext _todoContext;
        public TodoItemRepository(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public async Task<TodoItem?> Get(Guid id)
        {
            return await _todoContext.TodoItems.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<TodoItem>> GetAllPendingTodoItems()
        {
            return await _todoContext.TodoItems.Where(x => !x.IsCompleted).ToListAsync();
        }

        public Task Add(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }



        public Task Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}