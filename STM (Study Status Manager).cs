using System;
// Basic tools for entry and exit of info

using System.IO;
// Input/Output - specific tool to use codes related to computer files

class Program {
// Name of the code or class. Every program algorithm in C# must have a class (usually = Program)

    static void Main() {
    // Starting point of the algorithm, just do the task without returning values
    
        Console.Write("What's the studied subject? ");
        // Makes the question appear on the console to be answered
        
        string subject = Console.ReadLine();
        // Reads the info and saves it in a variable. Cannot have anything inside the "()"
        // String specifies the variable type: text. Every variable has a type in C#

        Console.Write("What's the progress percentage? ");
        string percentage = Console.ReadLine();

        Console.Write("What's the next task? ");
        string next_task = Console.ReadLine();
        // Console.ReadLine is like the input() command in Python

        File.AppendAllText("my_progress.txt", $"Subject: {subject}, Progress: {percentage}%, Next Task: {next_task}\n");
        // Console.Write is basically the print() command in Python, but without the automatic newline
        // \n = New line | Enter
    }
}

// All code lines inside methods must end with a semicolon ;
// $ works like 'f' in Python, used to indicate the existence of variables inside the text line
