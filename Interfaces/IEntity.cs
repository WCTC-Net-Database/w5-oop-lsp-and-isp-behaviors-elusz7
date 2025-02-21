namespace W5_assignment_template.Interfaces
{
    public interface IEntity
    {
        string Name { get; set; }
        public void Move();
        public void Attack(IEntity target);
    }
}
