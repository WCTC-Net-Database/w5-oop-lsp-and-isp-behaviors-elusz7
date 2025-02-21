using W5_assignment_template.Interfaces;
using W5_assignment_template.Commands;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _mage;
        private readonly IEntity _druid;
        private readonly List<ICommand> _commands;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity mage, IEntity druid)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _mage = mage;
            _druid = druid;
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
            _druid.Name = "Elf";

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
            ((ICastable)_mage).Spell = "Ice Knife";
            AddCommand(new CastCommand(_mage, _goblin));
            AddCommand(new CastCommand(_mage, _ghost, "Poison Spray"));
            AddCommand(new MoveCommand(_druid));
            AddCommand(new AttackCommand(_druid, _character));
            AddCommand(new ShiftCommand(_druid, "Tiger"));
            ((IShiftable)_druid).Form = "Fox";
            AddCommand(new ShiftCommand(_druid));
            AddCommand(new CastCommand(_druid, _goblin));
            ((ICastable)_druid).Spell = "Moonbeam";
            AddCommand(new CastCommand(_druid, _ghost));

            // Execute commands sequentially
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
