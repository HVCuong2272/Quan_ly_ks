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
    class NhaHangClass
    {
        MY_DB mydb = new MY_DB();
        
        public DataTable getTable()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID_Table as So_Phong,Type,Number_of_guests,Time,status,Price,Name_Custumer,Thanh_Toan FROM Ban ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable Find(string ID_Table)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM DatMon WHERE ID_Table=@ID_Table");
            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public DataTable getBans(SqlCommand command)
        {
           
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        
        public bool insertBan(string ID, string Type, string Number_of_guests, DateTime Time, string status,string Price, string Name_Custumer)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Ban (ID_Table, Type, Number_of_guests, Time, status, Price, Name_Custumer)" + "VALUES (@id,@type, @num, @time, @status, @Price, @Name_Custumer)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = Type;
            command.Parameters.Add("@num", SqlDbType.Int).Value = Number_of_guests;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = Time;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@Price", SqlDbType.VarChar).Value = Price; 
            command.Parameters.Add("@Name_Custumer", SqlDbType.VarChar).Value = Name_Custumer;


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

        public bool deleteBan(string ID_Table)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Ban WHERE ID_Table=@ID_Table", mydb.getConnection);
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

        public bool checkBan(string ID_Table)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Ban WHERE ID_Table = @ID_Table ", mydb.getConnection);

            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
           
            

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


        public bool updateBan(string ID_Table, string Type, string Number_of_guests, DateTime Time, string status, string Price, string Name_Custumer)
        {
            SqlCommand command = new SqlCommand("UPDATE Ban set  ID_Table=@ID_Table, Type=@Type, Number_of_guests=@Number_of_guests, Time = @Time ,status = @status ,Price = @Price ,Name_Custumer = @Name_Custumer WHERE  ID_Table=@ID_Table", mydb.getConnection);
            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
            command.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
            command.Parameters.Add("@Number_of_guests", SqlDbType.VarChar).Value = Number_of_guests;
            command.Parameters.Add("@Time", SqlDbType.DateTime).Value = Time;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status; 
            command.Parameters.Add("@Price", SqlDbType.VarChar).Value = Price; command.Parameters.Add("@Name_Custumer", SqlDbType.VarChar).Value = Name_Custumer;

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


        public DataTable getFood()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID_Food, Food_Name, Danh_Muc, Gia, Picture, Tinh_Trang FROM Food ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
       
        public bool insertFood(int ID_Food, string Food_Name, string Danh_Muc, int Gia, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Food (ID_Food, Food_Name, Danh_Muc, Gia, Picture)" + "VALUES (@ID_Food,@Food_Name, @Danh_Muc, @Gia, @Picture)", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Food_Name", SqlDbType.VarChar).Value = Food_Name;
            command.Parameters.Add("@Danh_Muc", SqlDbType.VarChar).Value = Danh_Muc;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();


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

        public bool updateFood(int ID_Food, string Food_Name, string Danh_Muc, int Gia, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Food set  ID_Food=@ID_Food, Food_Name=@Food_Name, Danh_Muc=@Danh_Muc, Gia = @Gia ,Picture = @Picture  WHERE  ID_Food=@ID_Food", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Food_Name", SqlDbType.VarChar).Value = Food_Name;
            command.Parameters.Add("@Danh_Muc", SqlDbType.VarChar).Value = Danh_Muc;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();

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



        public bool insertOrder(string ID_Table, int ID_Food, string Food_Name, string Danh_Muc, int Gia, int So_Luong, MemoryStream Picture,string Thanh_Toan,string Thuc_Hien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO DatMon ( ID_Table, ID_Food, Food_Name, Danh_Muc, Gia,So_Luong, Picture, Thanh_Toan,Thuc_Hien)" + "VALUES (@ID_Table, @ID_Food,@Food_Name, @Danh_Muc, @Gia, @So_Luong, @Picture, @Thanh_Toan,@Thuc_Hien)", mydb.getConnection);

            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;

            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@Food_Name", SqlDbType.VarChar).Value = Food_Name;
            command.Parameters.Add("@Danh_Muc", SqlDbType.VarChar).Value = Danh_Muc;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@So_Luong", SqlDbType.Int).Value = So_Luong;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = Picture.ToArray();
            command.Parameters.Add("@Thanh_Toan", SqlDbType.VarChar).Value = Thanh_Toan;
            command.Parameters.Add("@Thuc_Hien", SqlDbType.VarChar).Value = Thuc_Hien;



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

        public DataTable getOrder()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM DatMon  ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;





        }
        public DataTable getDT()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID_Table as So_Phong, ID_Food, Food_Name, Danh_Muc, Gia,So_Luong, Thanh_Toan FROM DatMon  ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;





        }
        public bool deleteDatMon(string ID_Table,int  ID_Food)
        {
            SqlCommand command = new SqlCommand("DELETE FROM DatMon WHERE  ID_Table = @ID_Table AND ID_Food=@ID_Food ", mydb.getConnection);
            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
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
        public bool checkFood(int ID_Food)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Food WHERE ID_Food = @ID_Food ", mydb.getConnection);

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
        public DataTable getFoods(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool updateSL(string ID_Table, int ID_Food, int So_Luong)
        {
            SqlCommand command = new SqlCommand("UPDATE DatMon set  So_Luong=@So_Luong  WHERE  ID_Table = @ID_Table AND ID_Food=@ID_Food ", mydb.getConnection);
            
            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;

            command.Parameters.Add("@ID_Food", SqlDbType.Int).Value = ID_Food;
            command.Parameters.Add("@So_Luong", SqlDbType.Int).Value = So_Luong;

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

        public bool checkMon(string ID_Table, int ID_Food)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM DatMon WHERE ID_Table=@ID_Table AND ID_Food=@ID_Food", mydb.getConnection);

            command.Parameters.Add("@ID_Table", SqlDbType.VarChar).Value = ID_Table;
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


        public bool updatePVIP(string So_Giuong, string Dieu_Hoa, string Ti_Vi,string CaFe ,string Ho_Boi,string Bua_Sang)
        {
            SqlCommand command = new SqlCommand("UPDATE phong set  So_Giuong=@So_Giuong,Dieu_Hoa=@Dieu_Hoa,Ti_Vi=@Ti_Vi,CaFe=@CaFe, Ho_Boi=@Ho_Boi,Bua_Sang=@Bua_Sang WHERE Loai='VIP'", mydb.getConnection);

            command.Parameters.Add("@So_Giuong", SqlDbType.VarChar).Value = So_Giuong;
            command.Parameters.Add("@Dieu_Hoa", SqlDbType.VarChar).Value = Dieu_Hoa;
            command.Parameters.Add("@Ti_Vi", SqlDbType.VarChar).Value = Ti_Vi;
            command.Parameters.Add("@CaFe", SqlDbType.VarChar).Value = CaFe;
            command.Parameters.Add("@Ho_Boi", SqlDbType.VarChar).Value = Ho_Boi;
            command.Parameters.Add("@Bua_Sang", SqlDbType.VarChar).Value = Bua_Sang;




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
        public bool updatePCAP(string So_Giuong, string Dieu_Hoa, string Ti_Vi, string CaFe, string Ho_Boi, string Bua_Sang)
        {
            SqlCommand command = new SqlCommand("UPDATE phong set  So_Giuong=@So_Giuong,Dieu_Hoa=@Dieu_Hoa,Ti_Vi=@Ti_Vi,CaFe=@CaFe, Ho_Boi=@Ho_Boi,Bua_Sang=@Bua_Sang WHERE Loai='CAP'", mydb.getConnection);

            command.Parameters.Add("@So_Giuong", SqlDbType.VarChar).Value = So_Giuong;
            command.Parameters.Add("@Dieu_Hoa", SqlDbType.VarChar).Value = Dieu_Hoa;
            command.Parameters.Add("@Ti_Vi", SqlDbType.VarChar).Value = Ti_Vi;
            command.Parameters.Add("@CaFe", SqlDbType.VarChar).Value = CaFe;
            command.Parameters.Add("@Ho_Boi", SqlDbType.VarChar).Value = Ho_Boi;
            command.Parameters.Add("@Bua_Sang", SqlDbType.VarChar).Value = Bua_Sang;




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


        public bool updatePDON(string So_Giuong, string Dieu_Hoa, string Ti_Vi, string CaFe, string Ho_Boi, string Bua_Sang)
        {
            SqlCommand command = new SqlCommand("UPDATE phong set  So_Giuong=@So_Giuong,Dieu_Hoa=@Dieu_Hoa,Ti_Vi=@Ti_Vi,CaFe=@CaFe, Ho_Boi=@Ho_Boi,Bua_Sang=@Bua_Sang WHERE Loai='DON'", mydb.getConnection);

            command.Parameters.Add("@So_Giuong", SqlDbType.VarChar).Value = So_Giuong;
            command.Parameters.Add("@Dieu_Hoa", SqlDbType.VarChar).Value = Dieu_Hoa;
            command.Parameters.Add("@Ti_Vi", SqlDbType.VarChar).Value = Ti_Vi;
            command.Parameters.Add("@CaFe", SqlDbType.VarChar).Value = CaFe;
            command.Parameters.Add("@Ho_Boi", SqlDbType.VarChar).Value = Ho_Boi;
            command.Parameters.Add("@Bua_Sang", SqlDbType.VarChar).Value = Bua_Sang;




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

        public DataTable getphong()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT So_Giuong, Dieu_Hoa, Ti_Vi, CaFe, Ho_Boi, Bua_Sang FROM phong ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;





        }
        public DataTable getphong0()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM phong ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;





        }

        public DataTable getGiamGia()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM Event ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getGiamGia2(string Code)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM Event WHERE Code=@Code");
            command.Parameters.Add("@Code", SqlDbType.VarChar).Value = Code;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertGGia(string Code, string Giam, DateTime Date)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Event ( Code, Giam, Date)" + "VALUES (@Code, @Giam,@Date)", mydb.getConnection);

            command.Parameters.Add("@Code", SqlDbType.VarChar).Value = Code;

            command.Parameters.Add("@Giam", SqlDbType.VarChar).Value = Giam;
            command.Parameters.Add("@Date", SqlDbType.DateTime).Value = Date;
            



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
        public bool deleteGGia(string Code)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Event WHERE Code=@Code", mydb.getConnection);
            command.Parameters.Add("@Code", SqlDbType.VarChar).Value = Code;
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
        public bool checkGGia(string Code)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Event WHERE Code=@Code ", mydb.getConnection);

            command.Parameters.Add("@Code", SqlDbType.VarChar).Value = Code;



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
