using Nancy;
using Nancy.ViewEngines.Razor;

namespace ToDoList
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Post["/task_added"] = _ => {
              var NewTask = new Task(Request.Form["new-task"]);
              // NewTask.Save();
              return View["task_added.cshtml", NewTask];
            };
            Get["/view_all_tasks"] = _ => {
              // var AllTasks = Task.ListOfTasks;
              var AllTasks = Task.All();
              return View["view_all_tasks.cshtml", AllTasks];
            };
            Post["/tasks_cleared"] = _ => {
              Task.DeleteAll();
              return View["tasks_cleared.cshtml"];
            };
        }
    }
}
