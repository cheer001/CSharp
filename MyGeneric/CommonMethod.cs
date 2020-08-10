using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    /// <summary>
    /// 常用方法
    /// </summary>
   public class CommonMethod
    {
        /// <summary>
        /// 打印int值
        /// 
        /// 方法声明时写死参数类型
        /// 
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowInt(int iParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(CommonMethod).Name,iParameter.GetType().Name,iParameter);
        }
        /// <summary>
        /// 打印string值
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowString(string sParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(CommonMethod).Name, sParameter.GetType().Name, sParameter);
        }
        /// <summary>
        /// 打印Date值
        /// </summary>
        /// <param name="dParameter"></param>
        public static void ShowDate(DateTime dParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(CommonMethod).Name, dParameter.GetType().Name, dParameter);
        }
        /// <summary>
        /// 打印Object值
        /// 1.Object类型是一切类型的父类
        /// 2.通过继承，子类拥有父类的一切属性和行为：任何父类出现的地方 都可以用子类代替 
        /// 
        /// object引用类型 传入int 类型会有拆箱装箱操作 会影响性能
        /// </summary>
        /// <param name="oParameter"></param>
        public static void ShowObject(object oParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(CommonMethod).Name, oParameter.GetType().Name, oParameter);
        }
    }
}
