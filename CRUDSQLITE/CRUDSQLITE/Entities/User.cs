namespace CRUDSQLITE.Entities
{
    internal class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
