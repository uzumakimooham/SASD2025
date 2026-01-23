using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101;

// 2
public class DuplicateCode
{
    public void Run()
    {
        string name = "Jimmy";
        Console.WriteLine("Owner : " + "name");
        Console.WriteLine("...");
        Console.WriteLine("Signed : " + "name");
    }
}

public class DuplicateCodeGood2
{
    string name = "Jimmy";
    public void Run()
    {
        PrintName("Owner");
        PrintBody();
        PrintName("Signed");
    }
    private void PrintName(string label)
    {
        Console.WriteLine(label + " : " + name);
    }
    private void PrintBody()
    {
        Console.WriteLine("...");
    }
}


