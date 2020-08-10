using System;

namespace MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int iValue = 123;
                string sValue = "456";
                DateTime dtValue = DateTime.Now;
                Object obj = "Mr.Zhang";

                Console.WriteLine("******************************");
                CommonMethod.ShowInt(iValue);
                CommonMethod.ShowString(sValue);
                CommonMethod.ShowDate(dtValue);

                CommonMethod.ShowObject(obj);
                CommonMethod.ShowObject(iValue);
                CommonMethod.ShowObject(sValue);
                CommonMethod.ShowObject(dtValue);

                Console.WriteLine("**************Generic****************");
                GenericMethod.Show<int>(iValue);
                GenericMethod.Show(iValue);//不写类型 默认会自动推算
                GenericMethod.Show<string>(sValue);
                GenericMethod.Show<DateTime>(dtValue);
                GenericMethod.Show<Object>(obj);

                GenericClass<int> genericClassInt = new GenericClass<int>()
                {
                    _T = 123
                };
                GenericClass<string> genericClassString = new GenericClass<string>()
                {
                    _T = "321"
                };

                Monitor.Show();

                Console.WriteLine("**************Constraint****************");
                People people = new People()
                {
                    Id = 123,
                    Name = "人"
                };
                Chinese chinese = new Chinese
                {
                    Id = 124,
                    Name = "中国人"
                };
                Hubei hubei = new Hubei()
                {
                    Id = 124,
                    Name = "湖北人"
                };
                Japanese japanese = new Japanese()
                {
                    Id = 125,
                    Name = "日本人"
                };
                Constraint.Show<People>(people);
                Constraint.Show<Chinese>(chinese);
                Constraint.Show<Hubei>(hubei);
                //Constraint.Show<Japanese>(japanese);


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
    }
}
