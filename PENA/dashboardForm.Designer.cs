namespace PENA
{
    partial class dashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTripNote = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUrutkan = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNik = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnData = new System.Windows.Forms.Button();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabTripNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabData.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabTripNote);
            this.tabControl.Controls.Add(this.tabData);
            this.tabControl.Location = new System.Drawing.Point(201, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(479, 347);
            this.tabControl.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDashboard.Controls.Add(this.btnData);
            this.tabDashboard.Controls.Add(this.label3);
            this.tabDashboard.Controls.Add(this.label2);
            this.tabDashboard.Controls.Add(this.label1);
            this.tabDashboard.Controls.Add(this.btnOthers);
            this.tabDashboard.Controls.Add(this.btnNote);
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(471, 321);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Icon Lain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Catatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Isi Data Perjalanan";
            // 
            // tabTripNote
            // 
            this.tabTripNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTripNote.Controls.Add(this.btnAddData);
            this.tabTripNote.Controls.Add(this.btnAdd);
            this.tabTripNote.Controls.Add(this.dataGridView);
            this.tabTripNote.Controls.Add(this.panel4);
            this.tabTripNote.Location = new System.Drawing.Point(4, 22);
            this.tabTripNote.Name = "tabTripNote";
            this.tabTripNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripNote.Size = new System.Drawing.Size(471, 321);
            this.tabTripNote.TabIndex = 1;
            this.tabTripNote.Text = "Catatan Perjalanan";
            this.tabTripNote.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 46);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.bodyTempDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tripModelBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(6, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(437, 178);
            this.dataGridView.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnUrutkan);
            this.panel4.Controls.Add(this.comboBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 34);
            this.panel4.TabIndex = 8;
            // 
            // btnUrutkan
            // 
            this.btnUrutkan.Location = new System.Drawing.Point(276, 5);
            this.btnUrutkan.Name = "btnUrutkan";
            this.btnUrutkan.Size = new System.Drawing.Size(75, 23);
            this.btnUrutkan.TabIndex = 11;
            this.btnUrutkan.Text = "Urutkan";
            this.btnUrutkan.UseVisualStyleBackColor = true;
            this.btnUrutkan.Click += new System.EventHandler(this.btnUrutkan_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(128, 7);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Urutkan Berdasarkan";
            // 
            // tabData
            // 
            this.tabData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabData.Controls.Add(this.panel5);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(471, 321);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "Isi Data ";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblError);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.txtTemp);
            this.panel5.Controls.Add(this.txtLocation);
            this.panel5.Controls.Add(this.dtpTime);
            this.panel5.Controls.Add(this.dtpDate);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 254);
            this.panel5.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(151, 139);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(31, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = " error";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(154, 107);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(204, 20);
            this.txtTemp.TabIndex = 7;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(154, 81);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(204, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(154, 54);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(204, 20);
            this.dtpTime.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(154, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(204, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Suhu Tubuh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lokasi yang dikunjungi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(21, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Jam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tanggal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNik);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 321);
            this.panel1.TabIndex = 6;
            // 
            // lblNik
            // 
            this.lblNik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNik.Location = new System.Drawing.Point(0, 188);
            this.lblNik.Name = "lblNik";
            this.lblNik.Size = new System.Drawing.Size(173, 24);
            this.lblNik.TabIndex = 3;
            this.lblNik.Text = "0000000000000000";
            this.lblNik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(0, 164);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(173, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "nama user";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnData
            // 
            this.btnData.BackgroundImage = global::PENA.Properties.Resources.write;
            this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnData.ForeColor = System.Drawing.Color.Transparent;
            this.btnData.Location = new System.Drawing.Point(34, 21);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(69, 69);
            this.btnData.TabIndex = 7;
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnOthers
            // 
            this.btnOthers.BackgroundImage = global::PENA.Properties.Resources.user;
            this.btnOthers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOthers.Location = new System.Drawing.Point(34, 154);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(69, 69);
            this.btnOthers.TabIndex = 3;
            this.btnOthers.UseVisualStyleBackColor = true;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackgroundImage = global::PENA.Properties.Resources.note1;
            this.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNote.ForeColor = System.Drawing.Color.Transparent;
            this.btnNote.Location = new System.Drawing.Point(189, 21);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(69, 69);
            this.btnNote.TabIndex = 2;
            this.btnNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.BackgroundImage = global::PENA.Properties.Resources.add2;
            this.btnAddData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddData.Location = new System.Drawing.Point(374, 244);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(69, 69);
            this.btnAddData.TabIndex = 12;
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::PENA.Properties.Resources.user_default;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Location = new System.Drawing.Point(38, 35);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 121);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Lokasi yang dikunjungi";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyTempDataGridViewTextBoxColumn
            // 
            this.bodyTempDataGridViewTextBoxColumn.DataPropertyName = "bodyTemp";
            this.bodyTempDataGridViewTextBoxColumn.HeaderText = "Suhu Tubuh";
            this.bodyTempDataGridViewTextBoxColumn.Name = "bodyTempDataGridViewTextBoxColumn";
            this.bodyTempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tripModelBindingSource
            // 
            this.tripModelBindingSource.DataSource = typeof(PENA.TripModel);
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 382);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "dashboardForm";
            this.Text = "User Control";
            this.Load += new System.EventHandler(this.dashboardForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabTripNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TabPage tabTripNote;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUrutkan;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tripModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNik;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnAddData;
    }
}