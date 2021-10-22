using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListApplication.Entities;

namespace ToDoListApplication.Services
{
    public class ToDoListService : IToDoListService
    {
        public ToDoListService()
        {
            ToDoList = new ToDoList();
        }
        private ToDoList ToDoList { get; set; }
        public List<string> GetToDoList()
        {
            return ToDoList.ToDoItems;
        }
    }
}
