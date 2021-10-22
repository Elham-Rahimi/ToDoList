using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApplication.Entities
{
    public class ToDoList
    {
        public ToDoList()
        {
            ToDoItems = new List<string>() { "Item1" , "Item2" , "Item3" };
        }
        public List<string> ToDoItems { get; set; }

        public void AddToDoItem(string todoItem)
        {
            ToDoItems.Add(todoItem);
        }
    }
}
