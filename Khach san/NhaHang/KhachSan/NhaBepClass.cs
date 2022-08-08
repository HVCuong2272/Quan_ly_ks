using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHang.NhaHang
{
    class NhaBepClass
    {
        MY_DB mydb = new MY_DB();
        public DataTable getOrder()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID_Table,ID_Food,Food_Name,Danh_Muc,So_Luong,Picture, Thuc_Hien FROM DatMon where Thuc_Hien <> 'Da Che Bien' AND Thuc_Hien='Chua' ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;





        }
        public DataTable getFood()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID_Food,Food_Name,Tinh_Trang FROM Food  ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool updateFood(int ID_Food,  string Tinh_Trang)
        {
            SqlCommand command = new SqlCommand("UPDATE Food set Tinh_Trang=@Tinh_Trang WHERE  ID_Food=@ID_Food", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Tinh_Trang", SqlDbType.VarChar).Value = Tinh_Trang;
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
        public bool updateSoPhan(int Id,int ID_Food, float SoPhan)
        {
            SqlCommand command = new SqlCommand("UPDATE NguyenLieu set SoPhan=@SoPhan WHERE  Id=@Id AND ID_Food=@ID_Food", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@SoPhan", SqlDbType.Float).Value = SoPhan;
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

        public bool updateThuc_Hien(int ID_Food,string ID_Table, string Thuc_Hien)
        {
            SqlCommand command = new SqlCommand("UPDATE DatMon set Thuc_Hien=@Thuc_Hien WHERE  ID_Food=@ID_Food AND ID_Table=@ID_Table ", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
            command.Parameters.Add("@Thuc_Hien", SqlDbType.VarChar).Value = Thuc_Hien;
           
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
        public bool insertNL(int Id, int ID_Food, string Name, int KhoiLuong, DateTime NgayNhap, float Phan)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NguyenLieu (Id, ID_Food, Name, KhoiLuong, NgayNhap,KLPhan )" + "VALUES (@Id,@ID_Food, @Name, @KhoiLuong, @NgayNhap,@KLPhan)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@KhoiLuong", SqlDbType.Int).Value = KhoiLuong;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = NgayNhap;
            command.Parameters.Add("@KLPhan", SqlDbType.Float).Value = Phan;


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

            command.CommandText = ("SELECT Id, ID_Food, Name, KhoiLuong, NgayNhap,KLPhan as KL_1Phan,SoPhan As Số_Phần FROM NguyenLieu ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool updateNL(int Id, int ID_Food, string Name, int KhoiLuong, DateTime NgayNhap, float phan)
        {
            SqlCommand command = new SqlCommand("UPDATE NguyenLieu set Id=@Id, ID_Food=@ID_Food, Name=@Name, KhoiLuong=@KhoiLuong, NgayNhap=@NgayNhap,KLPhan=@KLPhan WHERE  Id=@Id AND ID_Food=@ID_Food ", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@KhoiLuong", SqlDbType.Int).Value = KhoiLuong;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = NgayNhap;
            command.Parameters.Add("@KLPhan", SqlDbType.Float).Value = phan;

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
        public bool deleteNL(int Id, int ID_Food)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NguyenLieu WHERE  Id = @Id AND ID_Food=@ID_Food ", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
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
        public bool checkNL(int  Id, int ID_Food )
        {

            SqlCommand command = new SqlCommand("SELECT * FROM NguyenLieu WHERE Id = @Id  AND ID_Food=@ID_Food", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
