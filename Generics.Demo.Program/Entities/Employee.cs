namespace Generics.Demo.Program.Entities
{
    public class Employee : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, First name: {FirstName}";

    }
}
