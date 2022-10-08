using Boilerplate.Libraries.Data;
using Boilerplate.Libraries.Data.Interfaces;
using Boilerplate.Libraries.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Boilerplate.Libraries.Repositories
{
    public class TodoRepository : IMaintanable<Todo>
    {
        private readonly Context context;

        public TodoRepository(Context context)
        {
            this.context = context;
        }

        public void Create(Todo obj)
        {
            this.context?.Todos?.Add(obj);
            this.context?.SaveChanges();
        }

        public void Delete(string key)
        {
            var guid = Guid.Parse(key);

            var obj = this.context?.Todos?.SingleOrDefault(x => x.Id == guid);

            if (obj != null)
            {
                this.context?.Todos?.Remove(obj);
                this.context?.SaveChanges();
            }
        }

        public IEnumerable<Todo>? List()
        {
            return this.context?.Todos?.ToList();
        }

        public Todo? Retrieve(string key)
        {
            var guid = Guid.Parse(key);

            var obj = this.context?.Todos?.SingleOrDefault(x => x.Id == guid);

            return obj;
        }

        public void Update(Todo obj)
        {
            var databaseObj = this.context?.Todos?.SingleOrDefault(x => x.Id == obj.Id);

            if (databaseObj != null)
            {
                databaseObj.Text = obj.Text;
                this.context?.SaveChanges();
            }
        }
    }
}