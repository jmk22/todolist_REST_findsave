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
            Get["/tasks"] = _ => {
              var AllTasks = Task.All();
              return View["tasks.cshtml", AllTasks];
            };
            Get["/tasks/new"] = _ => {
              return View["task_form.cshtml"];
            };
            Post["/tasks"] = _ => {
              var NewTask = new Task(Request.Form["new-task"]);
              var AllTasks = Task.All();
              return View["tasks.cshtml", AllTasks];
            };
            Post["/tasks_cleared"] = _ => {
              Task.DeleteAll();
              return View["tasks_cleared.cshtml"];
            };
        }
    }
}
