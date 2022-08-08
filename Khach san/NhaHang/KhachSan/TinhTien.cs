using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.NhaHang
{
    class TinhTien
    {


        MY_DB mydb = new MY_DB();





        //public DataTable getTable(string ID_Table)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = mydb.getConnection;

        //    command.CommandText = ("SELECT * FROM DatMon WHERE ID_Table=@ID_Table "); command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;

        //}
       
        public DataTable getTable2(string ID_Table)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT  DatMon.ID_Table as So_Phong, Ban.Name_Custumer, DatMon.ID_Food, DatMon.Food_Name, DatMon.Danh_Muc, DatMon.Gia, DatMon.So_Luong, DatMon.Picture, DatMon.Thanh_Toan FROM DatMon INNER JOIN Ban ON DatMon.ID_Table = Ban.ID_Table WHERE DatMon.ID_Table=@ID_Table");

            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getFoods(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //public DataTable getbanAvai()
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = mydb.getConnection;

        //    command.CommandText = ("SELECT ID_Table FROM Ban ");

        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;

        //}

        public bool updateFood(string ID_Table)
        {
            SqlCommand command = new SqlCommand("UPDATE DatMon set Thanh_Toan='Da Thanh Toan' WHERE  ID_Table=@ID_Table", mydb.getConnection);
            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        
        public bool updateFood2(string ID_Table)
        {
            SqlCommand command = new SqlCommand("UPDATE Ban set Thanh_Toan='OK' WHERE  ID_Table=@ID_Table", mydb.getConnection);
            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
