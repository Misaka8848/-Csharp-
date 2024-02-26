namespace 成员属性
{
    class Hero
    {
        int hp;
        public int Id { get; set; }
        public int Hp
        {
            get
            {
                return hp; // 这里不能返回Hp 那样就变成递归调用了 
            }

            set
            {
                if (value < 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }
        public string State { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int Balance { get; set; }

        public Hero() : this(10)
        { }
        public Hero(int hp)
        {
            Hp = hp;
        }
        public void GetHurt(int dmg)
        {
            Hp -= dmg;
            if (Hp == 0) this.State = "Dead";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero();
            hero1.GetHurt(20);
            Console.WriteLine(hero1.State);
        }
    }
}