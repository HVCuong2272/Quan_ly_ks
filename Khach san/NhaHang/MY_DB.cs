using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NhaHang
{
    class MY_DB
    {
        // Khởi Tạo một chuỗi kết nối tới SQL Server từ link database
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Nhahang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // get the connection
            public SqlConnection getConnection
            {
                get
                {
                    return con;
                }
            }


            // open the connection
            public void openConnection()
            {
                if ((con.State == ConnectionState.Closed))
                {
                    con.Open();
                }

            }


            // close the connection
            public void closeConnection()
            {
                if ((con.State == ConnectionState.Open))
                {
                    con.Close();
                }

            }
        
    }
    }

