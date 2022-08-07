using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tiger : Animal
{

    public Tiger()
    {
        Name = "tiger";
        Weight = 100;
    }
    public override void Show()
    {
        Console.WriteLine("Name: " + Name + ", " + "Weight " + Weight);
    }
}
