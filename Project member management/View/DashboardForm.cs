using MemberManagementDashboard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class DashboardForm : Form
    {
        private List<Member> members = new List<Member>();

        public DashboardForm()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void LoadMembers()
        {
            try
            {
                // Cek koneksi database terlebih dahulu
                if (!Connect.TestConnection())
                {
                    MessageBox.Show("Tidak dapat terhubung ke database. Silakan periksa pengaturan koneksi Anda.",
                                   "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gunakan service GetAllMembersService
                var getService = new GetAllMember();
                members = getService.GetAll();
                RefreshMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshMemberList()
        {
            listViewMembers.Items.Clear();
            foreach (var member in members)
            {
                ListViewItem item = new ListViewItem(member.Id.ToString());
                item.SubItems.Add(member.Name);
                item.SubItems.Add(member.Email);
                item.SubItems.Add(member.Phone);
                item.Tag = member;
                listViewMembers.Items.Add(item);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            if (addMemberForm.ShowDialog() == DialogResult.OK)
            {
                Member newMember = addMemberForm.GetMember();

                var addService = new AddMember();
                if (addService.Add(newMember))
                {
                    LoadMembers(); // Reload data dari database
                    MessageBox.Show("Member sukses ditambahkan!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedItems.Count > 0)
            {
                Member selectedMember = (Member)listViewMembers.SelectedItems[0].Tag;
                EditMemberForm editMemberForm = new EditMemberForm(selectedMember);
                if (editMemberForm.ShowDialog() == DialogResult.OK)
                {
                    Member updatedMember = editMemberForm.GetMember();

                    var updateService = new UpdateMember();
                    if (updateService.Update(updatedMember))
                    {
                        LoadMembers(); // Reload data dari database
                        MessageBox.Show("Member berhasil diperbarui!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih member yang akan diperbarui.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewMembers.SelectedItems.Count > 0)
            {
                Member selectedMember = (Member)listViewMembers.SelectedItems[0].Tag;
                if (MessageBox.Show($"Apa kamu yakin akan menghapus data ini?: {selectedMember.Name}?",
                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deleteService = new DeleteMember();
                    if (deleteService.Delete(selectedMember.Id))
                    {
                        LoadMembers(); // Reload data dari database
                        MessageBox.Show("Member berhasil dihapus!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih member yang akan dihapus", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void listViewMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
