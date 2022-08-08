using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHang.NhanSu
{
    class CustomerClass
    {
        MY_DB mydb = new MY_DB();
        public bool insertCustomer(int Id, string Name, int Phone, string Email, string CCCD, string Address, string QuocTich, string UserName, string PassWord)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Customer (Id, Name, Phone, Email, CCCD,Address, QuocTich,UserName,PassWord)" + "VALUES (@Id,@Name, @Phone, @Email, @CCCD,@Address, @QuocTich,@UserName,@PassWord)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@Phone", SqlDbType.Int).Value = Phone;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = CCCD;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@QuocTich", SqlDbType.VarChar).Value = QuocTich;
            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = PassWord;


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
        public bool updateCustomer2(int Id, string Name, int Phone, string Email, string CCCD, string Address, string QuocTich, string UserName, string PassWord)
        {
            SqlCommand command = new SqlCommand("UPDATE  Customer  Set Id=@Id, Name=@Name, Phone=@Phone, CCCD = @CCCD ,Address = @Address, QuocTich=@QuocTich, UserName=@UserName, PassWord=@PassWord WHERE  Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@Phone", SqlDbType.Int).Value = Phone;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = CCCD;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@QuocTich", SqlDbType.VarChar).Value = QuocTich;
            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = PassWord;
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
        public bool updateCustomer(int Id, string Name, int Phone, string Email, string CCCD, string Address, string QuocTich)
        {
            SqlCommand command = new SqlCommand("UPDATE  Customer  Set Id=@Id, Name=@Name, Phone=@Phone, CCCD = @CCCD ,Address = @Address, QuocTich=@QuocTich WHERE  Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@Phone", SqlDbType.Int).Value = Phone;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@CCCD", SqlDbType.VarChar).Value = CCCD;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@QuocTich", SqlDbType.VarChar).Value = QuocTich;

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
        public DataTable getTable()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM Customer");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getTable2(string UserName, string PassWord)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * FROM Customer WHERE UserName=@UserName AND PassWord=@PassWord");
            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = PassWord;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getCus(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool deleteCustomer(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
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
