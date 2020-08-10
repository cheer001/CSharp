using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    public class Constraint
    {
        /// <summary>
        /// 泛型：不同的参数类型都可以传进来，在声明时无法获取类型中的结构
        /// 
        /// 泛型约束--基类约束：
        /// 1.限制后获取指定的类型及子类 可以基类的一切属性和方法
        /// 2.强制保证T一定是People或People的子类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter) 
            where T :People
        {
            //Console.WriteLine("This is {0},parameter={1},type={2}",
            //    typeof(GenericMethod), tParameter.GetType().Name, tParameter.ToString());
            Console.WriteLine("Id={0},Name={1},",
                tParameter.Id, tParameter.Name);
        }
    }
}
