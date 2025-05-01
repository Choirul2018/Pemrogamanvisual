using System.Drawing;
using System.Windows.Forms;

namespace MemberManagementDashboard
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string value)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox { Left = 20, Top = 20, Width = 240, Text = value };
            Button confirmation = new Button { Text = "Ok", Left = 170, Width = 90, Top = 60, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}
