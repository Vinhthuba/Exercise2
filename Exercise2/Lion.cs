using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lion : Animal
{
    public string Author;

    public Lion()
    {
        Name = "lion";
        Weight = 200;
    }
    public override void Show()
    {
        Console.WriteLine("Name: " + Name + ", " + "Weight " + Weight);

    }
}
