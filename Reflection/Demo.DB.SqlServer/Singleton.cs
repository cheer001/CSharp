using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DB.SqlServer
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        //静态的字段在程序内存中只有一个
        private static Singleton _Singleton = null;
        //将构造函数私有化，让外部不能进行其实例化
        private Singleton()
        {
            Console.WriteLine("Singleton被构造");
        }

        //静态构造函数会在程序打开时首先执行  进行实例的初始化
        static Singleton()
        {
            _Singleton = new Singleton();
        }
        //提供一个对外公开的方法获取实例
        public static Singleton GetInstance()
        {
            return _Singleton;
        }
    }
}
