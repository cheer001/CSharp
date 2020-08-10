using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    /// <summary>
    /// 一个类来满足不同的具体类型，做相同的事
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericClass<T>
    {
        public T _T;
    }
    /// <summary>
    /// 一个接口来满足不同的具体类型的接口，做相同的事
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericInterface<T>
    {
        T GetT(T t); //泛型类型的返回值
    }
    public delegate void SayHi<T>(T t);//泛型委托

    /// <summary>
    /// 实现泛型接口时 要么在泛型接口处指定类型  要么在实现类处与泛型接口同类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    //public class GenericClassImpl<T> : IGenericInterface<T>
    public class GenericClassImpl : IGenericInterface<int>
    {
        //public T GetT(T t)
        //{
        //    throw new NotImplementedException();
        //}

        public int GetT(int t)
        {
            throw new NotImplementedException();
        }
    }
}
