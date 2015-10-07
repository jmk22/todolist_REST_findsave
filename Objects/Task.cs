using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Task{
    private string _description;
    private bool _completed;
    private int _id;

    private static List<Task> instances = new List<Task> {};

    public Task(string taskDescription)
    {
      _description = taskDescription;
      _completed = false;
      _id = instances.Count + 1;
      // _id = ListOfTasks.Count;
      instances.Add(this);
    }


    public string GetDescription()
    {
      return _description;
    }
    // public void SetDescription(string newDescription)
    // {
    //   _description = newDescription;
    // }

    public bool IsCompleted(){
      return _completed;
    }
    public int GetId(){
      return _id;
    }
    // public void CompleteTask(){
    //   _completed = true;
    // }
    public static List<Task> All() {
      return instances;
    }
    // public static Task Find(int id){
    //   return instances[id-1];
    // }
    public static void DeleteAll()
    {
      instances.Clear();
    }
  }
}
