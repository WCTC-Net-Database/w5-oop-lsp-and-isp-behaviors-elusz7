using W5_assignment_template.Entities;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var goblin = new Goblin();
            var ghost = new Ghost();
            var mage = new Mage();

            var gameEngine = new GameEngine(character, goblin, ghost, mage);
            gameEngine?.Run();
        }

    }
}
