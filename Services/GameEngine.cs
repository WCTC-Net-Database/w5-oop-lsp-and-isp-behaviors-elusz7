using W5_assignment_template.Entities;
using W5_assignment_template.Interfaces;
using W5_assignment_template.Commands;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private IEntity _mage;
        private readonly List<ICommand> _commands;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _mage = mage;
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
            _mage.Name = "Sorcerer";

            // Add commands to the list
            AddCommand(new MoveCommand(_character));
            AddCommand(new AttackCommand(_character, _goblin));
            AddCommand(new MoveCommand(_goblin));
            AddCommand(new AttackCommand(_goblin, _ghost));
            AddCommand(new MoveCommand(_ghost));
            AddCommand(new AttackCommand(_ghost, _mage));
            AddCommand(new FlyCommand(_ghost));
            AddCommand(new MoveCommand(_mage));
            AddCommand(new CastCommand(_mage, _character));
            ((Mage)_mage).Spell = "Ice Knife";
            AddCommand(new CastCommand(_mage, _goblin));
            AddCommand(new CastCommand(_mage, _ghost, "Poison Spray"));

            // Execute commands sequentially
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
