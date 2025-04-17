using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Day
{
    public class DB
    {
        Edb edb;
        public DB()
        {
            edb = Edb.MYSQL;
        }
        public DB(Edb edb)
        { 
            this.edb = edb;
        }
        public void connect()
        {
            if (edb == Edb.MYSQL)
            {
                Console.WriteLine("MYSQL bağlantısı sağlandı.");
            }
            else if (edb == Edb.MSSQL)
            {
                Console.WriteLine("MSSQL bağlantısı sağlandı.");
            }
            else if (edb == Edb.SQLITE)
            {
                Console.WriteLine("SQLITE bağlantısı sağlandı.");
            }
        }
        public void close()
        {
            if (edb == Edb.MYSQL)
            {
                Console.WriteLine("MYSQL bağlantısı kapatıldı.");
            }
            else if (edb == Edb.MSSQL)
            {
                Console.WriteLine("MSSQL bağlantısı kapatıldı.");
            }
            else if (edb == Edb.SQLITE)
            {
                Console.WriteLine("SQLITE bağlantısı kapatıldı.");
            }
        }

    }
}
