using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TaskItem
    {
        public TaskItem(int taskId, string? taskDescription, bool isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

      public static  List<TaskItem> taskItems= new List<TaskItem>();


        public static  void DisplayToDoList() {
            var a = taskItems.FindAll(a => a.IsCompleted == true);
            var b = taskItems.FindAll(b => b.IsCompleted == false);
            if (a.Count > 0)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(" Task Id: {0}\n TaskDescription :{1}\n  IsCompleted : {2}", item.TaskId, item.TaskDescription,item.IsCompleted);
                }
            }
            if (b.Count > 0) { 
            
            foreach (var item in b)
                {
                    Console.WriteLine(" Task Id: {0}\n TaskDescription :{1}\n  IsCompleted : {2}", item.TaskId, item.TaskDescription, item.IsCompleted);
                }
            
            
            }
        
        }
    }
}
