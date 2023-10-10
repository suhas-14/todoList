using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

class Program
{
    static List<string> todoList = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your ToDo List Application!");

        while (true)
        {
            Console.WriteLine("Select your options: ");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View a task");
            Console.WriteLine("3. Mark task as completed");
            Console.WriteLine("4. Clear completed tasks");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    addTask();
                    break;

                case "2":
                    viewTask();
                    break;

                case "3":
                    markTaskCompleted();
                    break;

                case "4":
                    clearCompletedTask();
                    break;

                case "5":
                    exit();
                    break;

                default: Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void addTask()
    {
        Console.WriteLine("Enter a task: ");
        string Task = Console.ReadLine();
        todoList.Add(Task);
        Console.WriteLine("Task added!");
    }

    static void viewTask()
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("No task found!");
        }
        else
        {
            Console.WriteLine("To-Do List: ");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {todoList[i]}");
            }
        }

    }

    static void markTaskCompleted()
    {
        Console.WriteLine("Enter the no. of tasks to be marked as completed: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= todoList.Count)
        {
            int index = taskNumber - 1;
            Console.WriteLine($"Task '{todoList[index]}' marked as completed");
            todoList.RemoveAt(index);
        }else
        {
            Console.WriteLine("Invalid task number");
        }
    }

    static void clearCompletedTask()
    {
        todoList.RemoveAll(task => task.EndsWith("Completed"));
        Console.WriteLine("Compeleted task cleared.");
    }

    static void exit()
    {
        Environment.Exit(0);
    }

}


