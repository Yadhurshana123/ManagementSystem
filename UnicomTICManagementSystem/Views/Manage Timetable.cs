using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class Manage_timetable : Form
    {
        private int selectedTimetableId = -1;
        TimetableController controller = new TimetableController();
        public Manage_timetable()
        {
            InitializeComponent();
            LoadTimetables();
            LoadcomboModules();
            LoadcomboRooms();
        }

        public void ClearInputs() 
        {
            com_module.SelectedIndex = -1;
            com_room.SelectedIndex = -1;
            t_search.Clear();
            dtp_start_time.Value = DateTime.Today; 
            dtp_end_time.Value = DateTime.Today;  
        }
        public void LoadcomboModules() 
        {
            ModuleController controller = new ModuleController();
            List<Module> modules = controller.GetAllModules();

            com_module.DataSource = modules;
            com_module.DisplayMember = "ModuleName";
            com_module.ValueMember = "ModuleID";
        }

        public void LoadcomboRooms()
        {
            Roomcontroller controller = new Roomcontroller();
            List<Room> rooms = controller.GetAllRooms();

            com_room.DataSource = rooms;
            com_room.DisplayMember = "RoomType";
            com_room.ValueMember = "RoomID";
        }

        private void LoadTimetables()
        {
            TimetableController controller = new TimetableController();
            var list = controller.GetAllTimetables();
            dgv_timetable.DataSource = list;
            if(dgv_timetable.Columns["ModuleName"] != null)
                dgv_timetable.Columns["ModuleName"].Visible = false;

            if (dgv_timetable.Columns["RoomName"] != null)
                dgv_timetable.Columns["RoomName"].Visible = false;
        }

        public void HideAllControlsExceptDataGridView()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (!(ctrl is DataGridView))
                {
                    ctrl.Visible = false;
                }
                else
                {
                    ctrl.Visible = true;
                }
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (com_module.SelectedValue == null)
                {
                    MessageBox.Show("Please select a module.");
                    return;
                }

                if (com_room.SelectedValue == null)
                {
                    MessageBox.Show("Please select a room.");
                    return;
                }

                if (dtp_end_time.Value <= dtp_start_time.Value)
                {
                    MessageBox.Show("End time must be after start time.");
                    return;
                }

                var timetable = new Timetable
                {
                    ModuleID = (int)com_module.SelectedValue,
                    RoomID = (int)com_room.SelectedValue,
                    Date = dtp_date.Value.ToString("yyyy-MM-dd"),
                    StartTime = dtp_start_time.Value.TimeOfDay,
                    EndTime = dtp_end_time.Value.TimeOfDay
                };

                var controller = new TimetableController();
                controller.AddTimetable(timetable);

                MessageBox.Show("Timetable added successfully!");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding timetable: {ex.Message}");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTimetableId == -1)
                {
                    MessageBox.Show("Please select a timetable to edit.");
                    return;
                }

                if (com_module.SelectedItem == null || com_room.SelectedItem == null)
                {
                    MessageBox.Show("Please select both module and room.");
                    return;
                }

                if (dtp_end_time.Value <= dtp_start_time.Value)
                {
                    MessageBox.Show("End time must be after start time.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(dtp_start_time.Text) || string.IsNullOrWhiteSpace(dtp_end_time.Text) || string.IsNullOrWhiteSpace(dtp_date.Text))
                {
                    MessageBox.Show("Please select valid start,end times and date.");
                    return;
                }

                var timetable = new Timetable
                {
                    TimetableID = selectedTimetableId,
                    ModuleID = (int)com_module.SelectedValue,
                    RoomID = (int)com_room.SelectedValue,
                    Date = dtp_date.Value.ToString("yyyy-MM-dd"),
                    StartTime = dtp_start_time.Value.TimeOfDay,
                    EndTime = dtp_end_time.Value.TimeOfDay
                };

                controller.UpdateTimetable(timetable);
                MessageBox.Show("Timetable edited successfully!");
                LoadTimetables();     
                ClearInputs();          
                selectedTimetableId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing timetable: " + ex.Message);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTimetableId == -1)
                {
                    MessageBox.Show("Please select a timetable to delete.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this timetable?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    controller.DeleteTimetable(selectedTimetableId);
                    MessageBox.Show("Timetable Deleted Successfully");
                    LoadTimetables();   
                    ClearInputs();        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting timetable: " + ex.Message);
            }
        }

        private void dgv_timetable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_timetable.SelectedRows.Count > 0)
                {
                    var row = dgv_timetable.SelectedRows[0];
                    Timetable timetable = row.DataBoundItem as Timetable;
                    if (timetable != null)
                    {
                        selectedTimetableId = timetable.TimetableID;
                        com_module.SelectedValue = timetable.ModuleID;
                        com_room.SelectedValue = timetable.RoomID;
                        dtp_date.Value = DateTime.Parse(timetable.Date);
                        dtp_start_time.Value = DateTime.Today.Add(timetable.StartTime);
                        dtp_end_time.Value = DateTime.Today.Add(timetable.EndTime);
                    }
                    else
                    {
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void t_search_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(t_search.Text, out int id))
            {
                TimetableController controller = new TimetableController();
                Timetable result = controller.SearchTimetable(id);

                if (result != null)
                {
                    dgv_timetable.DataSource = new List<Timetable> { result };
                }

                else
                {
                    MessageBox.Show("Record not found!");
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Timetable ID");
            }
        }
    }
}
