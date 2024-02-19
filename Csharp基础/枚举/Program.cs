namespace 枚举
{

    #region  基本概念
    // 枚举是一个被命名的 整型常量 的集合
    // 用来表示 状态 类型等

    // 申明枚举 和 申明枚举变量 不一样
    // 声明枚举
    enum E_status
    {
        Start,// 默认为0, 后面的累加
        End,
        Quit=4 // 也可以显示指定 , 指定过后, 接下来的都会在这个基础上累加
    }
    
    
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            // 声明枚举变量
            E_status Status = E_status.Start;        

            #region  在哪里声明
            // 在namesapce声明(常用
            // 也可以在Class, struct声明
            // 注意: 不可以在函数语句块声明
            #endregion

            #region  枚举的使用

            #endregion

            #region  枚举的类型转换

            #endregion

            #region  枚举的作用

            #endregion

        }
    }
}