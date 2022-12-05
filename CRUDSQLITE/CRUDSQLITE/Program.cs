using CRUDSQLITE.Data;
using CRUDSQLITE.Entities;

using (DataContext context = new DataContext())
{
    Console.WriteLine("Enter User name");
    string name = Console.ReadLine();

    Console.WriteLine("Enter User Lastname");
    string lastName = Console.ReadLine();

    User user = new User()
    {
        Name = name,
        LastName = lastName
    };

    context.Users.Add(user);
    context.SaveChanges();

    var data = context.Users.ToList();

    Console.WriteLine(data.Count());

    data.ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, LastName: {x.LastName}"));

    Console.ReadKey();
}