using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class AttackCommand : ICommand
{
    public void Execute(IEntity self)
    {
        throw new NotImplementedException();
    }

    public void Execute(IEntity self, IEntity target)
    {
        Console.WriteLine($"{self.Name} attacks {target.Name}");
    }
}