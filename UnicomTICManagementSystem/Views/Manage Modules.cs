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
    public partial class Manage_Modules : Form
    {
        ModuleController controller = new ModuleController();
        private int selectedModuleId = -1;
        public Manage_Modules()
        {
            InitializeComponent();
            LoadModules();
            LoadComboCourse();
        }
        public void LoadComboCourse()
        {
            CourseController courseController = new CourseController();
            List<Course> courses = courseController.GetAllCourses();

            course_name.DataSource = courses;
            course_name.DisplayMember = "CourseName";
            course_name.ValueMember = "CourseID";
        }

        public void LoadModules()
        {
            var list = controller.GetAllModules();
            dgview_modules.DataSource = list;
        }

        private void ClearInputs()
        {
            tmodule.Text = "";
            t_search.Text = "";
            course_name.SelectedIndex = -1;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tmodule.Text))
                {
                    MessageBox.Show("Please enter module name");
                    return;
                }

                if (string.IsNullOrWhiteSpace(course_name.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }
                var module = new Module
                {
                    ModuleName = tmodule.Text,
                    ModuleID = selectedModuleId,
                    CourseID = (int)course_name.SelectedValue
                };

                controller.AddModule(module);
                MessageBox.Show("Module added successfully!");
                LoadModules();
                ClearInputs();
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
                if (selectedModuleId == -1)
                {
                    MessageBox.Show("Please select a module to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tmodule.Text))
                {
                    MessageBox.Show("Please enter module name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(course_name.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                var module = new Module
                {
                    ModuleID = selectedModuleId,
                    ModuleName = tmodule.Text,
                    CourseID = (int)course_name.SelectedValue
                };
                controller.UpdateModule(module);
                LoadModules();
                MessageBox.Show("Module edited successfully!");
                ClearInputs();
                selectedModuleId = -1;
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
                if (selectedModuleId == -1)
                {
                    MessageBox.Show("Please select a module to delete.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this module?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    controller.DeleteModule(selectedModuleId);
                    MessageBox.Show("Module Deleted Successfully");
                    LoadModules();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgview_modules_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgview_modules.SelectedRows.Count > 0)
                {
                    var row = dgview_modules.SelectedRows[0];
                    Module module = row.DataBoundItem as Module;
                    if (module != null)
                    {
                        selectedModuleId = module.ModuleID;
                        tmodule.Text = module.ModuleName;
                        course_name.SelectedValue = module.CourseID;
                    }
                }
                else
                {
                    selectedModuleId = -1;
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void t_search_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(t_search.Text, out int id))
            {
                ModuleController controller = new ModuleController();
                Module result = controller.SearchModule(id);

                if (result != null)
                {
                    dgview_modules.DataSource = new List<Module> { result };
                }

                else
                {
                    MessageBox.Show("Module not found!");
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Module ID");
            }
        }
    }
}

