using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.UseControl
{
    public partial class useRoom : UserControl
    {
        public useRoom()
        {
            InitializeComponent();
            LoadRoom1();
            LoadRoom2();
            LoadRoom3();
        }
        void LoadRoom1()
        {
            pnRoom1.Controls.Clear();
            List<Room> list = RoomDAO.Instance.LoadRoomList();
            int x  = 20;
            int y = 10;
            foreach (Room item in list)
            {

                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight, Margin = new Padding(10) };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Location = new Point(x, y);
                btn.Click += btn_Click1;
                btn.Tag = item;
                pnRoom1.Controls.Add(btn);
                switch (item.Status) 
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(153, 204, 255);
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(255, 204, 0);
                        break;
                }
                x += RoomDAO.RoomWidth;
                
            }

        }
        void LoadRoom2()
        {
            pnRoom2.Controls.Clear();
            List<Room> list = RoomDAO.Instance.LoadRoomListTang2();
            int x = 20;
            int y = 10;
            foreach (Room item in list)
            {

                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight, Margin = new Padding(10) };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Location = new Point(x, y);
                btn.Click += btn_Click2;
                btn.Tag = item;
                pnRoom2.Controls.Add(btn);
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(153, 204, 255);
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(255, 204, 0);
                        break;
                }
                x += RoomDAO.RoomWidth;

            }

        }
        void LoadRoom3()
        {
            pnRoom3.Controls.Clear();
            List<Room> list = RoomDAO.Instance.LoadRoomListTang3();
            int x = 20;
            int y = 10;
            foreach (Room item in list)
            {

                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight, Margin = new Padding(10) };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Location = new Point(x, y);
                btn.Click += btn_Click3;
                btn.Tag = item;
                pnRoom3.Controls.Add(btn);
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(153, 204, 255);
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(255, 204, 0);
                        break;
                }
                x += RoomDAO.RoomWidth;

            }

        }

        private void btn_Click1(object sender, EventArgs e)
        {
            Room room = (sender as Button).Tag as Room;
            ShowBillRoom billRoom = new ShowBillRoom(room.ID, room.Name);
            billRoom.ShowDialog();
            LoadRoom1();
            
        }
        private void btn_Click2(object sender, EventArgs e)
        {
            Room room = (sender as Button).Tag as Room;
            ShowBillRoom billRoom = new ShowBillRoom(room.ID, room.Name);
            billRoom.ShowDialog();
            LoadRoom2();

        }
        private void btn_Click3(object sender, EventArgs e)
        {
            Room room = (sender as Button).Tag as Room;
            ShowBillRoom billRoom = new ShowBillRoom(room.ID, room.Name);
            billRoom.ShowDialog();
            LoadRoom3();

        }
    }

}
