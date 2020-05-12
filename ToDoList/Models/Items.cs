using System.Collections.Generic;
using System;


namespace ToDoList.Models
{
  public class Item
  {

    private string _description {get; set;}
    
    private static List<Item> _instances = new List<Item>{};
   
    public Item(string description)
    {
        _description = description;
        _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
        return _instances;
    }

    public string GetDesc()
    {
      return _description;
    }
    
    public static void ClearAll()
    {
        _instances.Clear();
    }

  }
}