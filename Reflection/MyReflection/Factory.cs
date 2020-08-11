using Demo.DB.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace MyReflection
{
    /// <summary>
    /// 创建对象
    /// </summary>
    public class Factory
    {
        private static string IDBHelperConfig = ConfigurationManager.AppSettings["IDBHelperConfig"];
        private static string DllName = IDBHelperConfig.Split(',')[0];
        private static string TypeName = IDBHelperConfig.Split(',')[1];
        public static IDBHelper CreateHelper()
        {
            Assembly assembly = Assembly.Load(DllName);//dll名称无后缀  从当前目录加载  1.加载dll
            Type type = assembly.GetType(TypeName);  //2.获取类型信息
            object oDBHelper = Activator.CreateInstance(type);//3.创建对象
            IDBHelper iDBHelper = (IDBHelper)oDBHelper;//4.类型转换
            return iDBHelper;
        }
    }
}
