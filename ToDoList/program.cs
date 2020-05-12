using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoLists
{
    public class Program
    {
            
    
        public static void Main()
        {
              
                
            List<Item> myList = new List<Item>(){};
            int num = 1;
            for(int i = 0; i < num; i ++)
            {
                Console.WriteLine("Do You Want To Add To Your To-Do List? Press 1 for Yes, Any Key for No.");
                string answer = Console.ReadLine();
                if ( answer == "1")
                {
                    Console.WriteLine("Enter Description:");
                    string description = Console.ReadLine();
                    Item thisItem = new Item(description);
                    myList.Add(thisItem);
                    Console.WriteLine(thisItem.GetDesc());
                } else 
                {
                    int itemCnt = 1;
                    foreach(Item items in myList ) 
                    {
                        Console.WriteLine("To-Do List Item Number: " + itemCnt + " " + items.GetDesc());
                        itemCnt ++;
                    }
                    break;
                } 
                num ++; 
            }
        }
    }
}
