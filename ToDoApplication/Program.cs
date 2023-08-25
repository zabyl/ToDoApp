using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ToDoApplication.AppData;
using ToDoApplication.Application;
using static System.Net.Mime.MediaTypeNames;
using static ToDoApplication.Actions.AddAction;

namespace ToDoApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartApp.StartToDo();
        }

    }

}
