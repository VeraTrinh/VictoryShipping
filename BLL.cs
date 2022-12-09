using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VictoryShipping.DAL;

namespace VictoryShipping
{
    class BLL
    {
        //1. User of the Login system
        public class User
        {
            private string _username, _password;
            private User_DAM user_dam = new User_DAM();

            public User()
            {

            }
            public User(string username, string password)
            {
                _username = username;
                _password = password;
            }
            public bool InsertUser(string username, string password)
            {
                return user_dam.InsertUser(username, password);
            }

            public bool VerifyLogin(string username, string password)
            {
                return user_dam.VerifyLogin(username, password);
            }
        }

        //2. Parcel Info
        public class Parcel
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
            private Parcel_DAM parcel_dam = new Parcel_DAM();

            public Parcel()
            {

            }

            public bool InsertParcel(int ParcelID, string ParcelType, string Sender, string Receiver, string SenderAddress, string ReceiverAddress, string Destination, string Warehouse, int Price, DateTime Date, string DriverName, string Status)
            {
                return parcel_dam.InsertParcel(ParcelID, ParcelType, Sender, Receiver, SenderAddress, ReceiverAddress, Destination, Warehouse, Price, Date, DriverName, Status);
            }

            public bool UpdateParcel(int ParcelID, string ParcelType, string Sender, string Receiver, string SenderAddress, string ReceiverAddress, string Destination, string Warehouse, int Price, DateTime Date, string DriverName, string Status)
            {
                return parcel_dam.UpdateParcel(ParcelID, ParcelType, Sender, Receiver, SenderAddress, ReceiverAddress, Destination, Warehouse, Price, Date, DriverName, Status);
            }

            public bool DeleteParcel (int ParcelID)
            {
                return parcel_dam.DeleteParcel(ParcelID);
            }
        }
    }
}
