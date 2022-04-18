using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PENA
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

            txtNIK.MaxLength = 20;
            lblError.Text = "";
        }

        private void clear()
        {
            txtNIK.Clear();
            txtName.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            long nik;
            if(!long.TryParse(txtNIK.Text.Trim(),out nik)){
                lblError.Text = "NIK must be a number";
                return;
            }
            if (txtNIK.TextLength != 16)
            {
                lblError.Text = "NIK must be 16 character";
                return;
            }

            var user = Program.Users.Where(v => v.nik == nik).FirstOrDefault();
            if (user != null)
            {
                lblError.Text = "NIK sudah terdaftar";
                return;
            }

            lblError.ForeColor = Color.Green;
            lblError.Text = "Data berhasil didaftarkan";
            Program.Users.Add(new UserModel { name = txtName.Text.Trim(), nik = nik });
            Program.SaveCsvs();

            return;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            long nik;
            if (!long.TryParse(txtNIK.Text.Trim(), out nik))
            {
                lblError.ForeColor= Color.Red;
                lblError.Text = "NIK must be a number";
                return;
            }
            var name = txtName.Text.Trim();

            var user = Program.Users.Where(v => v.name.Equals(name) && v.nik == nik)
                .FirstOrDefault();

            if(user == null)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "User not found";
                return ;
            }

            Program.user = user;
            Hide();
            new dashboardForm().ShowDialog();
            Close();
            return;
        }
    }
}
