using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MemberManagementSystem
{
    public partial class EditMemberForm : Form
    {
        private Member editedMember;

        public EditMemberForm(Member member)
        {
            InitializeComponent();
            editedMember = member;

            // Fill form with member data
            txtName.Text = member.Name;
            txtEmail.Text = member.Email;
            txtPhone.Text = member.Phone;
            txtAddress.Text = member.Address;
        }

        public Member GetMember()
        {
            return editedMember;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                editedMember.Name = txtName.Text;
                editedMember.Email = txtEmail.Text;
                editedMember.Phone = txtPhone.Text;
                editedMember.Address = txtAddress.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}