using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    public interface IGeneric<T>
    {
        Task AddTask(Task task);
        Task RemoveTask(Task task);
        T CompleteTask(T task);
    }
}
