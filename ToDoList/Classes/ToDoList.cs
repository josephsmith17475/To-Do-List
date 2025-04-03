using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Classes;

namespace ToDoList.Classes
{
    public static class TDList
    {
        public static List<Task> Tasks { get; set; }

        public static void AddTask(Task task) { Tasks.Add(task); }
        public static void RemoveTask(string NameOfTask) 
        { 
            foreach(var task in Tasks)
            {
                if (task.NameOfTask == NameOfTask)
                {
                    Tasks.Remove(task);
                    return;
                }
            }
        }
    }
}
