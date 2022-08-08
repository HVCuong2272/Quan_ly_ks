using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHang.NhanSu
{
    class StaffClass
    {

        MY_DB mydb = new MY_DB();
        public DataTable getStaff(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool insertStaff(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture,string ChucVu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Staff (id, fname, lname, bdate, gender, phone, address, picture, ChucVu)" +
                "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic,@ChucVu)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@ChucVu", SqlDbType.VarChar).Value = ChucVu;
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
        //public bool checkKH(string Username, string Password)
        //{

        //    SqlCommand command = new SqlCommand("SELECT * FROM Staff WHERE Kich_Hoat = '1' AND Username =@Username AND Password=@Password", mydb.getConnection);

        //    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
        //    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;



        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();

        //    adapter.Fill(table);

        //    if (table.Rows.Count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public bool updateStaff(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture,string ChucVu)
        {
            SqlCommand command = new SqlCommand("UPDATE Staff set fname=@fn,lname=@ln,bdate=@bdt,gender=@gdr,phone=@phn, address=@adrs,picture=@pic, ChucVu=@ChucVu WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@ChucVu", SqlDbType.VarChar).Value = ChucVu;
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
        public bool deleteStaff(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Staff WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getCa()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Id,fname,lname,phone,ChucVu,Ca_Lam as Ca_1,Ca_Lam_2 as Ca_2,Check_In,Check_Out FROM Staff  ");
      
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getCaTD()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Id,fname,lname,phone,ChucVu,Ca_Lam as Ca_1,Ca_Lam_2 as Ca_2,Check_In,Check_Out FROM Staff  ");
         
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool insertAccount(string User, string Pass,int ID)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("UPDATE Staff set Username=@User,Password =@Pass WHERE Id=@ID", mydb.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = User;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Pass;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;



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
        public bool checkTQuyen(string Username, string Password)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Staff WHERE ChucVu = 'Quan Ly' AND Username = @Username AND Password=@Password", mydb.getConnection);

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;



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
        public bool checkTQuyen2(string Username, string Password)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE UserName = @UserName AND PassWord=@PassWord", mydb.getConnection);

            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = Password;



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

        public bool insertCalam(int Ca_Lam, DateTime Check_In, string Username, string Password)
        { 
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("UPDATE Staff set Ca_Lam=@Ca_Lam, Check_In=@Check_In WHERE  Username =@Username AND Password=@Password", mydb.getConnection);
            command.Parameters.Add("@Ca_Lam", SqlDbType.Int).Value = Ca_Lam;

            command.Parameters.Add("@Check_In", SqlDbType.DateTime).Value = Check_In;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;


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
        public bool insertCalam2( int Ca_Lam_2, string Username, string Password)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("UPDATE Staff set Ca_Lam_2=@Ca_Lam_2 WHERE  Username =@Username AND Password=@Password", mydb.getConnection);
            command.Parameters.Add("@Ca_Lam_2", SqlDbType.Int).Value = Ca_Lam_2;

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;


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
       

        
        public DataTable getAccount()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Id,fname,lname,ChucVu,Username,Password FROM Staff");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool updateCa(int Id, int Ca_Lam)
        {
            SqlCommand command = new SqlCommand("UPDATE Staff set Ca_Lam=@Ca_Lam WHERE  Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Ca_Lam", SqlDbType.Int).Value = Ca_Lam;

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
        public bool updateCa2(int Id, int Ca_Lam_2)
        {
            SqlCommand command = new SqlCommand("UPDATE Staff set Ca_Lam_2=@Ca_Lam_2 WHERE  Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Ca_Lam_2", SqlDbType.Int).Value = Ca_Lam_2;

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

        public bool UpdateC_Out( DateTime Check_Out, string Username, string Password)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("UPDATE Staff set  Check_Out=@Check_Out WHERE  Username =@Username AND Password=@Password", mydb.getConnection);
            command.Parameters.Add("@Check_Out", SqlDbType.DateTime).Value = Check_Out;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;


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
        public DataTable getCa2()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Id,fname,lname,phone,ChucVu,Ca_Lam as Ca_1,Ca_Lam_2 as Ca_2,Check_In,Check_Out,Luong,So_Gio FROM Staff");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool updateGio(int So_Gio,int Id )
        {
            SqlCommand command = new SqlCommand("UPDATE Staff set So_Gio=@So_Gio WHERE Id=@Id", mydb.getConnection);
            command.Parameters.Add("@So_Gio", SqlDbType.Int).Value = So_Gio;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

            //command.Parameters.Add("@Ca_Lam_1", SqlDbType.Int).Value = Ca_Lam_1;
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
        public bool updateLuong(float Luong, int Id)
        {
            SqlCommand command = new SqlCommand("UPDATE Staff set Luong=@Luong WHERE Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Luong", SqlDbType.Float).Value = Luong;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

            //command.Parameters.Add("@Ca_Lam_1", SqlDbType.Int).Value = Ca_Lam_1;
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
        public DataTable getCa1(string Username, string Password)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Ca_lam FROM Staff WHERE  Username =@Username AND Password=@Password");
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }


        




    }
}
