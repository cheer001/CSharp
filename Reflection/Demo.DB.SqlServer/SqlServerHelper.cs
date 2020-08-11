using Demo.DB.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DB.SqlServer
{
    class SqlServerHelper : IDBHelper
    {
        public SqlServerHelper()
        {
            //Console.WriteLine("{0}被构造", this.GetType().Name);
        }
        public void Query()
        {
            //Console.WriteLine("{0},Query", this.GetType().Name);
        }
    }
}
