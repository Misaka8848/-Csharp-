namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();
            //int i = r.Next(); // 生成一个非负随机数
            //i = r.Next(100); // 产生0-99随机数
            //i = r.Next(1,10); // 1-9
            //Console.WriteLine(i);
            #region 习题
            Random r = new Random();

            int userAtk = 0;
            int monsDef = 10, monsHeal = 20;
            int dmg = 0;
            int i = 0;
            while (true)
            {   
                userAtk = r.Next(8, 13);
                dmg = userAtk > monsDef ? userAtk - monsDef : 0;
                monsHeal -= dmg;
                i++;
                if (monsHeal <= 0) {
                    Console.WriteLine("**********");
                    Console.WriteLine($"造成了 {dmg} 点伤害, 击败了怪物. 进行了 {i} 次攻击");
                    Console.WriteLine("**********");
                    break;
                }
                else
                {
                    Console.WriteLine($"造成了 {dmg} 点伤害, 怪物还剩{monsHeal} 点生命值");
                }
            }
            Console.WriteLine("游戏结束");
            #endregion
        }
    }
}