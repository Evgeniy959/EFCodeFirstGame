using System;
using System.IO;
using System.Text.Json;

namespace JsonFile
{
    class Program
    {
        public class ConnectToDbConfig
        {
            public ConnectionString ConnectionString { get; set; }
        }
        public class ConnectionString 
        {
            public string DefaultConnection { get; set; }
        }

        static void Main()
        {
            var connect = new ConnectToDbConfig
            {
                ConnectionString = new ConnectionString 
                {
                    DefaultConnection = "Server=mysql60.hostland.ru; Database = host1323541_sbd16; Uid = host1323541_itstep; Pwd = 269f43dc;"
                }              
            };
            using var file = new FileStream("connect_to_db_config.json", FileMode.OpenOrCreate);
            JsonSerializer.SerializeAsync(file, connect);
        }
    }
}
