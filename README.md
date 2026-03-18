# Still... Day 1: Study Status Manager 🪐

A simple script first made in Python (but now, on C#), to organize the study process created on my first day on solo study.

## 🔌 How does it work? (Same as in Python, but in C#)
- It collects info about the subject's name, progress percent and the next task via keyboard
- Save all info automatically on a local `.txt` file.
- Keeps a log (it doesn't delete what has been written before).

## 🌊 Today's learning (again!):
- File manipulation on C# by using `using System.IO` and `File.AppendAllText`.
- Structure of a basic algoritm on C#, and the differences to Python (same code, but different syntax).
- Use of Identity Files (.csproj).
- Discovery of Compilation artifacts.

##  📸 Infastructure learning C#
- Everytime C# runs something he makes files with compilation artifacts, temporary codes that he uses to execute a algoritm, can be deleted (it'll be created again anyway);
- C# has commands that are more direct but more specific than on Python, it makes C# has more security than Python;
- C# can't run a algoritm without the identity file (.sln or .csproj), they specify the type of the code, this one is a executable algoritm;
- The difference is that .csproj takes care of only one algoritm, and .sln function is to conect multiple algoritms that needs to work together, if you have 4 algoritms for a website for example, you can conect them in a gropu with .sln and use .csproj to specify the function of each one for C# to run them;
- It's more easy to just open the terminal (Ctrl + ') and use "dotnet new console" for .csproj;
- For sln is more specific "dotnet new sln -n Setname";
- -n = name

---
*Learning different languages with the same algoritm.* 
