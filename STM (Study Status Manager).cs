using System;
// Basic tools of entry and exit of info
using System.IO;
// Input/Output - specific tool to use codes related to computer files

class Program{
// Name of the code or class, every program algoritm on C# may have a class (mainly = Program)
    static void Main() {
    // Starting point of the algorithm, just do the task without math values
        Console.Write("What's the studied subject?");
        // Makes the question appear on the console to be answered
        string subject = Console.ReadLine();
        //Reads the info and save it on a variable, cannot have anything inside the "()"
        // String specifies that the variable type: text. Every variable has a type on C#

        Console.Write("What's the progress percentage?");
        string percentage = Console.ReadLine();

        Console.Write("What's the next task?");
        string next_task = Console.ReadLine();

        // Console.ReadLine is like the command input on Python

        File.AppendAllText("my_progress.txt", $"Subject:{subject}, Progress:{percentage}%, Next Task:{next_task}n/");
        // Console.Write is basically the command print on Python, but it needs another command to read the text
        // /n = New line | Enter
    }

}

// All the code lines must end with a semicolon ;.
// $ works like a f on Python, is to indicate the existence of variables on the line of text (resulting on the need to get the info collected of these variables)
