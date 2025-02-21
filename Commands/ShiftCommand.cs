using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands
{
    public class ShiftCommand : ICommand
    {
        private readonly IEntity Self;
        private string Form;

        public ShiftCommand(IEntity self)
        {
            this.Self = self;
            this.Form = ((IShiftable)self).Form;
        }

        public ShiftCommand(IEntity self, string form)
        {
            this.Self = self;
            this.Form = form;
        }

        public void SetForm(string form)
        {
            this.Form = form;
        }

        public void Execute()
        {
            Console.WriteLine($"{Self.Name} shifts into {Form}");
        }

    }
}
