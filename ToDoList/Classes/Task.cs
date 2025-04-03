using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    public class Task
    {
        public string NameOfTask { get; set; }
        public bool TaskDone { get; set; }
        Task() { NameOfTask = string.Empty; TaskDone = false; }
    }
}
