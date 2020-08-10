using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyGeneric
{
    public class Monitor
    {
        public static void Show()
        {
            Console.WriteLine("*************Monitor******************");
            {
                int iValue = 12345;
                long commonSecond = 0;
                long objectSecond = 0;
                long genericSecond = 0;
                long genericSecond2 = 0;
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        ShowInt(iValue);
                    }
                    watch.Stop();
                    commonSecond = watch.ElapsedMilliseconds;//经过的毫秒数
                }
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        ShowObject(iValue);
                    }
                    watch.Stop();
                    objectSecond = watch.ElapsedMilliseconds;//经过的毫秒数
                }
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        Show<int>(iValue);
                    }
                    watch.Stop();
                    genericSecond = watch.ElapsedMilliseconds;//经过的毫秒数
                }
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        Show(iValue);
                    }
                    watch.Stop();
                    genericSecond2 = watch.ElapsedMilliseconds;//经过的毫秒数
                }
                /*
                 commonSecond=225,objectSecond=561,genericSecond=238,genericSecond2=251
                 objectSecond 经过的毫秒数比较高 是因为它会有拆箱装箱的操作
                 */
                Console.WriteLine("commonSecond={0},objectSecond={1},genericSecond={2},genericSecond2={3}",
                    commonSecond, objectSecond, genericSecond, genericSecond2);
            }
        }

        private static void Show<T>(T iValue)
        {
            //
        }

        private static void ShowObject(object iValue)
        {
           //
        }

        private static void ShowInt(int iValue)
        {
            //
        }
    }
}
