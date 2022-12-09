using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictoryShipping
{
    class DAL
    {
        public class User_DAM
        {
            private string _username, _password;
            private string conStr = @"Data Source=09207429-HONG; Initial Catalog=dbVictoryShipping; Integrated Security=True";

            public User_DAM()
            {

            }
            public User_DAM(string username, string password)
            {
                _username = username;
                _password = password;
            }
            public bool InsertUser(string username, string password)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string cmdStr = "INSERT INTO [dbo].[USER](Username, Password) VALUES (@username,@password)";
                    SqlCommand cmd = new SqlCommand(cmdStr, con);
                    cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    con.Close();
                }

                return false;
            }
             
            public bool VerifyLogin(string username, string password)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string cmdStr = "SELECT * FROM [dbo].[USER] WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(cmdStr, con);
                    cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    con.Close();
                }

                return false;
            }
        }
        //2. Parcel_Dam
        public class Parcel_DAM
        {
            private int _ParcelID;
            private string _ParcelType;
            private string _Sender;
            private string _Receiver;
            private string _SenderAddress;
            private string _ReceiverAddress;
            private string _Destination;
            private string _Warehouse;
            private int _Price;
            private DateTime _Date;
            private string _DriverName;
            private string _Status;
            private string conStr = @"Data Source=09207429-HONG; Initial Catalog=dbVictoryShipping; Integrated Security=True";
            public Parcel_DAM()
            {

            }

            public bool InsertParcel(int ParcelID, string ParcelType, string Sender, string Receiver, string SenderAddress, string ReceiverAddress, string Destination, string Warehouse, int Price, DateTime Date, string DriverName, string Status)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string strCmd = "INSERT INTO [dbo].[PARCEL](ParcelID, ParcelType, Sender, Receiver, SenderAddress, ReceiverAddress, Destination, Warehouse, Price, Date, DriverName, Status) VALUES (@ParcelID, @ParcelType, @Sender, @Receiver, @SenderAddress, @ReceiverAddress, @Destination, @Warehouse, @Price, @Date, @DriverName, @Status)";
                    SqlCommand cmd = new SqlCommand(strCmd, con);
                    cmd.Parameters.AddWithValue("@ParcelID", SqlDbType.Int).Value = ParcelID;
                    cmd.Parameters.AddWithValue("@ParcelType", SqlDbType.VarChar).Value = ParcelType;
                    cmd.Parameters.AddWithValue("@Sender", SqlDbType.VarChar).Value = Sender;
                    cmd.Parameters.AddWithValue("@Receiver", SqlDbType.VarChar).Value = Receiver;
                    cmd.Parameters.AddWithValue("@SenderAddress", SqlDbType.VarChar).Value = SenderAddress;
                    cmd.Parameters.AddWithValue("@ReceiverAddress", SqlDbType.VarChar).Value = ReceiverAddress;
                    cmd.Parameters.AddWithValue("@Destination", SqlDbType.VarChar).Value = Destination;
                    cmd.Parameters.AddWithValue("@Warehouse", SqlDbType.VarChar).Value = Warehouse;
                    cmd.Parameters.AddWithValue("@Price", SqlDbType.Int).Value = Price;
                    cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = Date;
                    cmd.Parameters.AddWithValue("@DriverName", SqlDbType.VarChar).Value = DriverName;
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = Status;
                    con.Open();
                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        return true;
                    con.Close();
                }

                return false;
            }

            public bool UpdateParcel(int ParcelID, string ParcelType, string Sender, string Receiver, string SenderAddress, string ReceiverAddress, string Destination, string Warehouse, int Price, DateTime Date, string DriverName, string Status)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string strCmd = "UPDATE [dbo].[PARCEL] SET ParcelID = @ParcelID, ParcelType = @ParcelType , Sender = @Sender, Receiver = @Receiver, SenderAddress = @SenderAddress, ReceiverAddress = @ReceiverAddress, Destination = @Destination, Warehouse = @Warehouse, Price = @Price, Date = @Date, DriverName = @DriverName, Status = @Status" +
                        " " +
                   "WHERE ParcelID = @ParcelID";
                    SqlCommand cmd = new SqlCommand(strCmd, con);
                    cmd.Parameters.AddWithValue("@ParcelID", SqlDbType.Int).Value = ParcelID;
                    cmd.Parameters.AddWithValue("@ParcelType", SqlDbType.VarChar).Value = ParcelType;
                    cmd.Parameters.AddWithValue("@Sender", SqlDbType.VarChar).Value = Sender;
                    cmd.Parameters.AddWithValue("@Receiver", SqlDbType.VarChar).Value = Receiver;
                    cmd.Parameters.AddWithValue("@SenderAddress", SqlDbType.VarChar).Value = SenderAddress;
                    cmd.Parameters.AddWithValue("@ReceiverAddress", SqlDbType.VarChar).Value = ReceiverAddress;
                    cmd.Parameters.AddWithValue("@Destination", SqlDbType.VarChar).Value = Destination;
                    cmd.Parameters.AddWithValue("@Warehouse", SqlDbType.VarChar).Value = Warehouse;
                    cmd.Parameters.AddWithValue("@Price", SqlDbType.Int).Value = Price;
                    cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = Date;
                    cmd.Parameters.AddWithValue("@DriverName", SqlDbType.VarChar).Value = DriverName;
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = Status;
                    con.Open();
                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        return true;
                    con.Close();
                }

                return false;
            }

            public bool DeleteParcel(int ParcelID)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string strCmd = "DELETE FROM [dbo].[PARCEL] WHERE ParcelID = @ParcelID";
                    SqlCommand cmd = new SqlCommand(strCmd, con);
                    cmd.Parameters.AddWithValue("@ParcelID", SqlDbType.Int).Value = ParcelID;
                    con.Open();
                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        return true;
                    con.Close();
                }
                return true;
            }
        }
    }
}
