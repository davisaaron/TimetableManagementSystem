using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace TimetableManagementSystem
{
    class Config
    {
        public static MySqlConnection con = new MySqlConnection(@"Server=mysql-31703-0.cloudclusters.net;Database=timetablemngsysdb3;Uid=admin;Pwd=4CrYvo6F;port=31744");

        /*
        Use this as
        SqlConnection con = Config.con;
        In your class
        make sure to import SqlClient as
        using System.Data.SqlClient;
        */
    }
}