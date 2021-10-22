using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApplication.Services
{
    public interface IToDoListService
    {
        List<string> GetToDoList();
    }
}
