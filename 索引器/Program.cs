namespace 索引器
{
    class Team
    {
        string[] arr = new string[10];
        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}