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
    private readonly IEntity self;
    public FlyCommand(IEntity entity)
    {
        this.self = entity;
    }
    public void Execute()
    {
        Console.WriteLine($"{self.Name} flies rapidly through the air.");
    }
}

