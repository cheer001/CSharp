using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    /// <summary>
    /// 泛型方法
    /// </summary>
    public class GenericMethod
    {
        /// <summary>
        /// 2.0推出的新语法
        /// 泛型方法 解决用一个方法，满足不同的参数类型：做相同的事
        /// 没有写死参数类型，调用的时候才指定类型
        /// 
        /// 延迟声明: 把参数类型的声明推迟到调用
        /// 不是语法糖，而是由框架升级提供的功能
        /// 
        /// </summary>
        /// <typeparam name="T">调用时传递的类型  不传递的话  会按照参数值来推算参数的类型</typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(GenericMethod), tParameter.GetType().Name, tParameter.ToString());
        }

        public static void ShowObject(object oParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}",
                typeof(GenericMethod), oParameter.GetType().Name, oParameter.ToString());
        }
    }
}
