﻿using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly List<ICommand> _commands;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";

            // Add commands to the list
            AddCommand(new MoveCommand(_character));
            AddCommand(new AttackCommand(_character, _goblin));
            AddCommand(new MoveCommand(_goblin));
            AddCommand(new AttackCommand(_goblin, _ghost));
            AddCommand(new MoveCommand(_ghost));
            AddCommand(new AttackCommand(_ghost, _character));
            AddCommand(new FlyCommand(_ghost));

            // Execute commands sequentially
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
