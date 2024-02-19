namespace 枚举习题
{
    internal class Program
    {
        enum E_QStatus
        {
            Online,
            Invisible,
            Busy,
            Chatme
        }
        enum E_Coffee
        {
            middle = 35,
            large = 40,
            exlarge = 32
        }
        enum E_male
        {
            atkPlus = 50,
            defPlus = 100
        }
        enum E_female
        {
            atkPlus = 150,
            defPlus = 20
        }
        enum E_playerClassWorrior
        {
            atkPlus = 20,
            defPlus = 100,
            skill = 0
        }
        enum E_playerClassMage
        {
            atkPlus = 200,
            defPlus = 10,
            skill = 1
        }
        enum E_playerClassHunter
        {
            atkPlus = 120,
            defPlus = 30,
            skill = 2
        }
        static void Main(string[] args)
        {


            #region 1
            //1. 定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型

            string userInput;
            bool isQuit = false;
            int inputStatus;
            E_QStatus userStatus = E_QStatus.Busy;
            while (!isQuit)
            {
                Console.Clear();
                Console.WriteLine("选择一个状态, 0:在线, 1:隐身, 2:在忙,3:Q我吧");
                userInput = Console.ReadLine();
                inputStatus = int.Parse(userInput);



                userStatus = E_QStatus.Online;

                switch (inputStatus)
                {
                    case 0: userStatus = E_QStatus.Online; isQuit = true; break;
                    case 1: userStatus = E_QStatus.Invisible; isQuit = true; break;
                    case 2: userStatus = E_QStatus.Busy; isQuit = true; break;
                    case 3: userStatus = E_QStatus.Chatme; isQuit = true; break;
                    default: Console.WriteLine("输入有误 "); isQuit = false; break;

                }

            }

            Console.WriteLine($"你的状态是{userStatus}");

            #endregion
            #region 2
            //2. 用户去星巴克买咖啡，分为中杯(35元)，大杯(40元)，超大杯(43元)，请用户选择要购买的类型，用户选择后，打印：您购买了Xx咖啡，花费了x元例如：你购买了中杯咖啡，花费了35元
            string userInput2 = " ";
            E_Coffee Coffee = E_Coffee.large;

            // 输入检查
            do
            {
                userInput2 = Console.ReadLine();
                if (userInput2 == "中杯" || userInput2 == "大杯" || userInput2 == "超大杯")
                {
                    break;
                }

            } while (true);
            switch (userInput2)
            {
                case "中杯": Coffee = E_Coffee.middle; break;
                case "大杯": Coffee = E_Coffee.large; break;
                case "超大杯": Coffee = E_Coffee.exlarge; break;
            }
            Console.WriteLine($"你购买的是{Coffee}, 花费{(int)Coffee}元");

            #endregion
            #region 3
            //            1.定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
            //2.用户去星巴克买咖啡，分为中杯(35元)，大杯(40元)，超大杯(43元)，请用户选择要购买的类型，用户选择后，打印：您购买了Xx咖啡，花费了x元例如：你购买了中杯咖啡，花费了35元
            //3.请用户选择英雄性别与英雄职业，最后打印英雄的基本属性（攻击力，防御力，技能)性别：
            //  男(攻击力 + 50，防御力 + 100)
            //  女(攻击力 + 150，防御力 + 20)
            //  职业：战士
            //  (攻击力 + 20，防御力 + 100，技能：冲锋)
            //  猎人（攻击力 + 120，防御力 + 30，技能：假死)
            //  法师(攻击力 + 200，防御力 + 10，技能：奥术冲击)
            //  举例打印：你选择了“女性法师”，攻击力：350，防御力：30，职业
            //  技能：奥术冲击
            int playerAtk = 0, playerDef = 0, playerSkillCode = 0;
            string playerClass = " ";
            string playerinput = " ";
            Console.WriteLine("输入你的性别");
            playerinput = Console.ReadLine();
            switch (playerinput)
            {
                case "男":
                    playerAtk += (int)E_male.atkPlus;
                    playerDef += (int)E_male.defPlus;
                    break;

                default:
                    playerAtk += (int)E_female.atkPlus;
                    playerDef += (int)E_female.defPlus;
                    break;
            }
            Console.WriteLine("输入你的职业");
            playerinput = Console.ReadLine();
            switch (playerinput)
            {
                case "战士":
                    playerAtk += (int)E_playerClassWorrior.atkPlus;
                    playerDef += (int)E_playerClassWorrior.defPlus;
                    break;
            }
            Console.WriteLine($"你的攻击力是{playerAtk}, 防御力是{playerDef},职业是{playerClass} ");
            #endregion
            #region 4   

            #endregion
        }



    }
}
