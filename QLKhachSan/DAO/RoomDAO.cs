using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return instance; }
            private set { instance = value; }
        }
        public RoomDAO() { }
        public static int RoomWidth = 120;
        public static int RoomHeight = 120;
        public List<Room>  LoadRoomList()
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuQuery("USP_GETLISTROOM");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                list.Add(room);
            }
            return list;
        }
        public List<Room> LoadRoomListTang2()
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuQuery("USP_GETLISTROOMTANG2");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                list.Add(room);
            }
            return list;
        }
        public List<Room> LoadRoomListTang3()
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuQuery("USP_GETLISTROOMTANG3");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                list.Add(room);
            }
            return list;
        }
        public List<Room> LoadAllRoomList()
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuQuery("USP_GETLISTALLROOM");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                list.Add(room);
            }
            return list;
        }
        public bool InsertRoom(string name)
        {
            string query = string.Format("INSERT INTO Phong (name,status) VALUES ('{0}',N'Trống' )", name);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        
        public bool UpdateRoom(string name, int id)
        {

            string query = string.Format("UPDATE Phong SET name = N'{0}' where id = {1}", name,id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
       
        public bool DeleteRoom(int id)
        {
            
            string query = string.Format("DELETE Phong WHERE id = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
  }
