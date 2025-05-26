using MemberManagementDashboard;
using System;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load Dashboard Form inside the panel
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }
    }
}