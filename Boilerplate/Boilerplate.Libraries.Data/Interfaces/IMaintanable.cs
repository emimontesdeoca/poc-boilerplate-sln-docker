using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Libraries.Data.Interfaces
{
    public interface IMaintanable<T>
    {
        IEnumerable<T>? List();
        void Create(T obj);
        T? Retrieve(string key);
        void Update(T obj);
        void Delete(string key);
    }
}
