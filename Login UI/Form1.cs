using System;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateLoginButtonState();
        }

        private void age_click(object sender, EventArgs e)
        {

        }

        private void lastname_click(object sender, EventArgs e)
        {

        }

        private void name_click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                send.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                send.Enabled = false;
            }
        }

        private void agetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            var username = nametextbox.Text ?? string.Empty;
            var password = agetextbox.Text ?? string.Empty;

            if (username != "admin" && password == "1234")
            {
                MessageBox.Show("ไม่มีผู้ใช้ดังกล่าวในระบบ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optionally handle other cases (e.g., success)
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("เข้าสู่ระบบเรียบร้อย", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateLoginButtonState()
        {
            send.Enabled = !string.IsNullOrWhiteSpace(nametextbox.Text) && !string.IsNullOrWhiteSpace(agetextbox.Text);
        }
    }
}