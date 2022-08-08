using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.NhaHang;

namespace NhaHang.NhaHang
{
    class QLMon
    {
        MY_DB mydb = new MY_DB();


        public DataTable getFood()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM Food ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;





        }
        public bool checkTinhTrang( int ID_Food)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Food WHERE Tinh_Trang = 'Ready' AND ID_Food = @ID_Food", mydb.getConnection);

            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
          


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertFood(int ID_Food, string Food_Name, string Danh_Muc, int Gia, MemoryStream Picture, string Tinh_Trang, string Mo_Ta)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Food (ID_Food, Food_Name, Danh_Muc, Gia, Picture,Tinh_Trang, Mo_Ta)" + "VALUES (@ID_Food,@Food_Name, @Danh_Muc, @Gia, @Picture,@Tinh_Trang, @Mo_Ta)", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Food_Name", SqlDbType.VarChar).Value = Food_Name;
            command.Parameters.Add("@Danh_Muc", SqlDbType.VarChar).Value = Danh_Muc;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();
            command.Parameters.Add("@Tinh_Trang", SqlDbType.VarChar).Value = Tinh_Trang;
            command.Parameters.Add("@Mo_Ta", SqlDbType.VarChar).Value = Mo_Ta;


            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public DataTable getTable()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM Food");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool updateFood(int ID_Food, string Food_Name, string Danh_Muc, int Gia, MemoryStream Picture, string Tinh_Trang, string Mo_Ta)
        {
            SqlCommand command = new SqlCommand("UPDATE Food set  ID_Food=@ID_Food, Food_Name=@Food_Name, Danh_Muc=@Danh_Muc, Gia = @Gia ,Picture = @Picture, Tinh_Trang=@Tinh_Trang, Mo_Ta=@Mo_Ta   WHERE  ID_Food=@ID_Food", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Food_Name", SqlDbType.VarChar).Value = Food_Name;
            command.Parameters.Add("@Danh_Muc", SqlDbType.VarChar).Value = Danh_Muc;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();
            command.Parameters.Add("@Tinh_Trang", SqlDbType.VarChar).Value = Tinh_Trang;
            command.Parameters.Add("@Mo_Ta", SqlDbType.VarChar).Value = Mo_Ta;
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
        public DataTable getFoods(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool deleteFood(int ID_Food)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Food WHERE ID_Food=@ID_Food", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
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

        public DataTable getFoods2(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }







    }
}
