using System.Windows.Forms;

namespace MemberManagementSystem
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelControls = new Panel();
            btnAddMember = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            listViewMembers = new ListView();
            columnId = new ColumnHeader();
            columnName = new ColumnHeader();
            columnEmail = new ColumnHeader();
            columnPhone = new ColumnHeader();
            lblDashboardTitle = new Label();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // panelControls
            // 
            panelControls.Controls.Add(btnAddMember);
            panelControls.Controls.Add(btnEdit);
            panelControls.Controls.Add(btnDelete);
            panelControls.Controls.Add(btnRefresh);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 96);
            panelControls.Margin = new Padding(5, 6, 5, 6);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1333, 115);
            panelControls.TabIndex = 0;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(46, 204, 113);
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(33, 19);
            btnAddMember.Margin = new Padding(5, 6, 5, 6);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(200, 77);
            btnAddMember.TabIndex = 0;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(267, 19);
            btnEdit.Margin = new Padding(5, 6, 5, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 77);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(500, 19);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 77);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(730, 19);
            btnRefresh.Margin = new Padding(5, 6, 5, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 77);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // listViewMembers
            // 
            listViewMembers.Columns.AddRange(new ColumnHeader[] { columnId, columnName, columnEmail, columnPhone });
            listViewMembers.Dock = DockStyle.Fill;
            listViewMembers.FullRowSelect = true;
            listViewMembers.GridLines = true;
            listViewMembers.Location = new Point(0, 211);
            listViewMembers.Margin = new Padding(5, 6, 5, 6);
            listViewMembers.Name = "listViewMembers";
            listViewMembers.Size = new Size(1333, 895);
            listViewMembers.TabIndex = 1;
            listViewMembers.UseCompatibleStateImageBehavior = false;
            listViewMembers.View = View.Details;
            listViewMembers.SelectedIndexChanged += listViewMembers_SelectedIndexChanged;
            // 
            // columnId
            // 
            columnId.Text = "ID";
            columnId.Width = 50;
            // 
            // columnName
            // 
            columnName.Text = "Nama";
            columnName.Width = 200;
            // 
            // columnEmail
            // 
            columnEmail.Text = "Email";
            columnEmail.Width = 250;
            // 
            // columnPhone
            // 
            columnPhone.Text = "No hp";
            columnPhone.Width = 150;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.Dock = DockStyle.Top;
            lblDashboardTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(0, 0);
            lblDashboardTitle.Margin = new Padding(5, 0, 5, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(1333, 96);
            lblDashboardTitle.TabIndex = 2;
            lblDashboardTitle.Text = "Member Dashboard";
            lblDashboardTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 1106);
            Controls.Add(listViewMembers);
            Controls.Add(panelControls);
            Controls.Add(lblDashboardTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "DashboardForm";
            Text = "Dashboard";
            panelControls.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listViewMembers;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Button btnRefresh;
    }
}