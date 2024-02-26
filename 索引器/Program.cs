namespace 索引器
{
    public class Person
    {
        public string Name
        { get; set; }

    }
    public class Team
    {
        private Person[] members = new Person[5];

        public Person this[int index]
        {
            get { return members[index]; }
            set { members[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            team[0] = new Person() { Name = "Alice" };
            Console.WriteLine(team[0].Name);
        }
    }
}