using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;
public class FlyCommand : ICommand
{
    public void Execute(IEntity self)
    {
        Console.WriteLine($"{self.Name} flies rapidly through the air.");
    }

    public void Execute(IEntity self, IEntity target)
    {
        throw new NotImplementedException();
    }
}

