using Demo.DB.Interface;
using Demo.DB.MySql;
using Demo.DB.SqlServer;
using System;
using System.Reflection;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Common
                {
                    Console.WriteLine("*****************Common********************");
                    IDBHelper iDBHelper = new MySqlHelper();
                    iDBHelper.Query();

                }
                {
                    Console.WriteLine("*****************Reflection********************");
                    Assembly assembly = Assembly.Load("Demo.DB.MySql");//dll名称无后缀  从当前目录加载  1.加载dll
                    Assembly assembly1 = Assembly.LoadFile(
                        @"E:\learnspace\.NetProject\CSharp\Reflection\MyReflection\bin\Debug\netcoreapp3.1\Demo.DB.MySql.dll");
                    //完整路径的加载   可以是别的目录  加载不会错，但是没有依赖项，使用的时候会错
                    Assembly assembly2 = Assembly.LoadFrom("Demo.DB.MySql.dll");//带后缀或者完整路径  

                    foreach (var item in assembly.GetModules())
                    {
                        Console.WriteLine(item.FullyQualifiedName);
                    }
                    foreach (var item in assembly.GetTypes())
                    {
                        Console.WriteLine(item.FullName);
                    }
                    Type type = assembly.GetType("Demo.DB.MySql.MySqlHelper");  //2.获取类型信息
                    object oDBHelper = Activator.CreateInstance(type);//3.创建对象
                    //oDBHelper.Query();//oDBHelper是object 不能调用到Query方法，但实际上Query方法是有的  编译器不认可
                    IDBHelper iDBHelper = (IDBHelper)oDBHelper;//4.类型转换
                    iDBHelper.Query();//5.方法调用
                }
                {
                    //IOC
                    Console.WriteLine("*****************Reflection+Factory+Config********************");
                    IDBHelper iDBHelper = Factory.CreateHelper();
                    iDBHelper.Query(); // 可配置可扩展  反射是动态的 依赖的是字符串
                }
                {
                    Console.WriteLine("*****************Reflection+Object********************");
                    Singleton singleton1 = Singleton.GetInstance();
                    Singleton singleton2 = Singleton.GetInstance();
                    Singleton singleton3 = Singleton.GetInstance();
                    {
                        Assembly assembly = Assembly.Load("Demo.DB.SqlServer");
                        Type type = assembly.GetType("Demo.DB.SqlServer.Singleton");
                        Singleton singleton4 =(Singleton)Activator.CreateInstance(type, true);
                        Singleton singleton5 =(Singleton)Activator.CreateInstance(type, true);
                        Singleton singleton6 =(Singleton)Activator.CreateInstance(type, true);
                    }
                    {
                        Assembly assembly = Assembly.Load("Demo.DB.SqlServer");
                        Type type = assembly.GetType("Demo.DB.SqlServer.GenericClass`3");// 使用反单引号(`)后面跟泛型个数
                        Type newType = type.MakeGenericType(new Type[] { typeof(int), typeof(string), typeof(DateTime) });
                        object oGeneric = Activator.CreateInstance(newType);
                    }
                }
                {

                }
                #endregion
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
