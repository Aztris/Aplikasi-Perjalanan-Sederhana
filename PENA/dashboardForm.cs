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
    public partial class dashboardForm : Form
    {
        BindingSource source = new BindingSource();

        static dashboardForm()
        {
            Directory.CreateDirectory(Program.EXE_DIR + @"\data\profile_pictures\");
        }

        public dashboardForm()
        {
            InitializeComponent();

        }

        private void clear()
        {
            dtpDate.Value=DateTime.Now;
            dtpTime.Value=DateTime.Now;
            txtLocation.Clear();
            txtTemp.Clear();
        }

        private void updateImage()
        {
            pbImage.ImageLocation = Program.EXE_DIR + @"\data\profile_pictures\" + Program.user.image;
        }

        private void updateData()
        {
            source.DataSource = Program.Trips.Where(v => v.nik == Program.user.nik).ToList();
            source.ResetBindings(false);
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            lblUser.Text = Program.user.name.ToString().ToUpper();

            lblNik.Text = Program.user.nik.ToString();

            updateData();
            dataGridView.DataSource = source;

            comboBox.Items.Add("Tanggal");
            comboBox.Items.Add("Waktu");
            comboBox.Items.Add("Lokasi");
            comboBox.SelectedIndex = 0;

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd-MM-yyyy";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH.mm";

            dtpDate.Value
                = dtpTime.Value
                = DateTime.Now;

            openFileDialog.Filter = "*.png|*.jpg";
            updateImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var date = dtpDate.Value;
            var time = dtpTime.Value;
            var loc = txtLocation.Text.Trim();
            double temp;
            if(!double.TryParse(txtTemp.Text.Trim(), out temp))
            {
                return;
            }

            if(txtLocation.Text=="" || txtTemp.Text == "")
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Pastikan data sudah lengkap";
                return;
            }

            Program.Trips.Add(new TripModel { nik = Program.user.nik, date = date.ToString("dd-MM-yyyy"), time = time.ToString("HH.mm"), location = loc, bodyTemp = temp });
            Program.SaveCsvs();
            updateData();

            lblError.ForeColor = Color.Green;
            lblError.Text = "Data Berhasil Disimpan";

            clear();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabData;
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabTripNote;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabData;
        }



        private void btnUrutkan_Click(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0: // Tanggal
                    Program.Trips.Sort((a, b) => a.GetDate().CompareTo(b.GetDate()));
                    break;
                case 1: // Waktu
                    Program.Trips.Sort((a, b) => a.GetTime().CompareTo(b.GetTime()));
                    break;
                case 2: // Lokasi
                    Program.Trips.Sort((a, b) => a.location.CompareTo(b.location));
                    break;
            }
            updateData();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabData;
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            pbImage_Click(sender, e);
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
            string distName = Program.user.nik + fileInfo.Extension;
            File.Copy(fileInfo.FullName, Program.EXE_DIR + @"\data\profile_pictures\" + distName, true);
            Program.user.image = distName;
            Program.SaveCsvs();
            updateImage();
        }

    }
}
