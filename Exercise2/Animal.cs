using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Animal
{
    public int Weight { get; set; }
    public string Name { get; set; }

    public virtual void Show()
    {
        Console.WriteLine($"{Weight} {Name}");
    }
}