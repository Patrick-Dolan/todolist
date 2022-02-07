using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your To Do List.");
      string userAnswer = "add";

      while (userAnswer == "add" || userAnswer == "view")
      {
      Console.WriteLine("Would you like to add an item to your list or view you list? (Add/View)");
      userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "add")
        {
        Console.WriteLine("Please enter a description for the new item:");
        Item newItem = new Item(Console.ReadLine());
        Console.WriteLine(" '" + newItem.Description + "' " + "has been added to your list.");
        } 
        else if (userAnswer == "view")
        {
          List<Item> list = new List<Item> {};
          list = Item.GetAll();
          if (list.Count == 0)
          {
            Console.WriteLine("You don't have any items on your list.");
          }
          int counter = 1;
          foreach (Item item in list)
          {
            string number = counter.ToString();
            Console.WriteLine(number + ". " + item.Description);
            counter++;
          }
        }
      }
      Console.WriteLine("Shutting down application now. Goodbye.");
    }
  }
}