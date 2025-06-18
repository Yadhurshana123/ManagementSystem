using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class ManageRooms : Form
    {
        private int selectedRoomtId = -1;
        Roomcontroller controller = new Roomcontroller();

        public ManageRooms()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void ClearForm()
        {
            troom.Clear();
            ttype.Clear();
        }
        public void LoadRooms()
        {
            var list = controller.GetAllRooms();
            dgview_rooms.DataSource = list;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(troom.Text) || string.IsNullOrWhiteSpace(ttype.Text))
                {
                    MessageBox.Show("Please enter all requirements");
                    return;
                }

                var rooms = new Room
                {
                    RoomName = troom.Text,
                    RoomType = ttype.Text,
                };
                controller.AddRoom(rooms);
                LoadRooms();
                MessageBox.Show("Room added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRoomtId == -1)
                {
                    MessageBox.Show("Please select a room to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(troom.Text) ||
                    string.IsNullOrWhiteSpace(ttype.Text))
                {
                    MessageBox.Show("Please enter all requirments fields.");
                    return;
                }

                var room = new Room 
                {
                    RoomID = selectedRoomtId,
                    RoomName = troom.Text,
                    RoomType = ttype.Text,
                };
                controller.AddRoom(room);
                LoadRooms();
                MessageBox.Show("Room edited successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try 
            {
                if (selectedRoomtId == -1) 
                {
                    MessageBox.Show("Please select a room to delete.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) 
                {
                    controller.DeleteRoom(selectedRoomtId);
                    LoadRooms();
                    MessageBox.Show("Room deleted successfully!");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgview_rooms_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgview_rooms.SelectedRows.Count > 0)
                {
                    var row = dgview_rooms.SelectedRows[0];
                    Room room = row.DataBoundItem as Room;
                    if (room != null)
                    {
                        selectedRoomtId = room.RoomID;
                        troom.Text = room.RoomName;
                        ttype.Text = room.RoomType;
                    }
                    else
                    {
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
