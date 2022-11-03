namespace UserStruct;

public class userStruct
{
    static void Main()
    {
        Console.Clear();
        var user = new User(20, "Abraão", "Oliveira", 1.70);
        Console.WriteLine($"Name: {user.Name}\nLastName: {user.LastName}\nYears: {user.Year}\nHeight: {user.Height}");
    }
    struct User
    {
        public User(int year, string name, string lastName, double height)
        {
            Year = year;
            Name = name;
            LastName = lastName;
            Height = height;
        }
        public int Year { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
    }
}