using Boilerplate.Libraries.Data.Models;
using Boilerplate.Libraries.Repositories;
using System.Net;

namespace Boilerplate.Libraries.Services
{
    public class TodoService
    {
        private readonly TodoRepository todoRepository;

        public TodoService(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public void Create(Todo obj)
        {
            this.todoRepository.Create(obj);
        }

        public void Delete(string key)
        {
            this.todoRepository.Delete(key);
        }

        public IEnumerable<Todo> List()
        {
            return this.todoRepository.List();
        }

        public Todo Retrieve(string key)
        {
            return this.todoRepository.Retrieve(key);
        }

        public void Update(Todo obj)
        {
            this.todoRepository.Update(obj);
        }
    }
}