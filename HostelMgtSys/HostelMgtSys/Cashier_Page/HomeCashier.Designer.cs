namespace HostelMgtSys.Cashier_Page
{
    partial class HomeCashier
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
            this.lbltime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbluser = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabavailableroom = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.DataGridAvailableRoom = new System.Windows.Forms.DataGridView();
            this.tabnewhosteller = new MetroFramework.Controls.MetroTabPage();
            this.cbprintreceipt = new System.Windows.Forms.CheckBox();
            this.btnprintreceiptp = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtroomno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtroomid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtnationalty = new MetroFramework.Controls.MetroTextBox();
            this.txtphone = new MetroFramework.Controls.MetroTextBox();
            this.txtoname = new MetroFramework.Controls.MetroTextBox();
            this.txtlname = new MetroFramework.Controls.MetroTextBox();
            this.txtfname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnreset = new MetroFramework.Controls.MetroButton();
            this.btnavailableroom = new MetroFramework.Controls.MetroButton();
            this.btnsubmit = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnlogout = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabavailableroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAvailableRoom)).BeginInit();
            this.tabnewhosteller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.CustomForeColor = true;
            this.lbltime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbltime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbltime.Location = new System.Drawing.Point(23, 60);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(38, 19);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "Time";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(575, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Welcome";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.CustomForeColor = true;
            this.lbluser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbluser.Location = new System.Drawing.Point(645, 60);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(35, 19);
            this.lbluser.TabIndex = 4;
            this.lbluser.Text = "User";
            this.lbluser.Visible = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabavailableroom);
            this.metroTabControl1.Controls.Add(this.tabnewhosteller);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 82);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(745, 392);
            this.metroTabControl1.TabIndex = 1;
            // 
            // tabavailableroom
            // 
            this.tabavailableroom.BackColor = System.Drawing.SystemColors.Info;
            this.tabavailableroom.Controls.Add(this.metroLabel16);
            this.tabavailableroom.Controls.Add(this.DataGridAvailableRoom);
            this.tabavailableroom.HorizontalScrollbarBarColor = true;
            this.tabavailableroom.Location = new System.Drawing.Point(4, 35);
            this.tabavailableroom.Name = "tabavailableroom";
            this.tabavailableroom.Size = new System.Drawing.Size(737, 353);
            this.tabavailableroom.TabIndex = 0;
            this.tabavailableroom.Text = "Available Rooms";
            this.tabavailableroom.VerticalScrollbarBarColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.CustomForeColor = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel16.Location = new System.Drawing.Point(0, 11);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(154, 25);
            this.metroLabel16.TabIndex = 92;
            this.metroLabel16.Text = "Available Rooms";
            // 
            // DataGridAvailableRoom
            // 
            this.DataGridAvailableRoom.AllowUserToAddRows = false;
            this.DataGridAvailableRoom.AllowUserToDeleteRows = false;
            this.DataGridAvailableRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridAvailableRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAvailableRoom.Location = new System.Drawing.Point(13, 47);
            this.DataGridAvailableRoom.Name = "DataGridAvailableRoom";
            this.DataGridAvailableRoom.ReadOnly = true;
            this.DataGridAvailableRoom.Size = new System.Drawing.Size(361, 303);
            this.DataGridAvailableRoom.TabIndex = 2;
            // 
            // tabnewhosteller
            // 
            this.tabnewhosteller.Controls.Add(this.cbprintreceipt);
            this.tabnewhosteller.Controls.Add(this.btnprintreceiptp);
            this.tabnewhosteller.Controls.Add(this.metroLabel5);
            this.tabnewhosteller.Controls.Add(this.metroLabel4);
            this.tabnewhosteller.Controls.Add(this.txtroomno);
            this.tabnewhosteller.Controls.Add(this.metroLabel10);
            this.tabnewhosteller.Controls.Add(this.txtroomid);
            this.tabnewhosteller.Controls.Add(this.metroLabel2);
            this.tabnewhosteller.Controls.Add(this.txtnationalty);
            this.tabnewhosteller.Controls.Add(this.txtphone);
            this.tabnewhosteller.Controls.Add(this.txtoname);
            this.tabnewhosteller.Controls.Add(this.txtlname);
            this.tabnewhosteller.Controls.Add(this.txtfname);
            this.tabnewhosteller.Controls.Add(this.metroLabel6);
            this.tabnewhosteller.Controls.Add(this.metroLabel7);
            this.tabnewhosteller.Controls.Add(this.metroLabel3);
            this.tabnewhosteller.Controls.Add(this.metroLabel8);
            this.tabnewhosteller.Controls.Add(this.metroLabel9);
            this.tabnewhosteller.Controls.Add(this.btnreset);
            this.tabnewhosteller.Controls.Add(this.btnavailableroom);
            this.tabnewhosteller.Controls.Add(this.btnsubmit);
            this.tabnewhosteller.HorizontalScrollbarBarColor = true;
            this.tabnewhosteller.Location = new System.Drawing.Point(4, 35);
            this.tabnewhosteller.Name = "tabnewhosteller";
            this.tabnewhosteller.Size = new System.Drawing.Size(737, 353);
            this.tabnewhosteller.TabIndex = 1;
            this.tabnewhosteller.Text = "New Hosteller";
            this.tabnewhosteller.VerticalScrollbarBarColor = true;
            // 
            // cbprintreceipt
            // 
            this.cbprintreceipt.AutoSize = true;
            this.cbprintreceipt.Location = new System.Drawing.Point(505, 179);
            this.cbprintreceipt.Name = "cbprintreceipt";
            this.cbprintreceipt.Size = new System.Drawing.Size(87, 17);
            this.cbprintreceipt.TabIndex = 98;
            this.cbprintreceipt.Text = "Print Receipt";
            this.cbprintreceipt.UseVisualStyleBackColor = true;
            this.cbprintreceipt.Visible = false;
            this.cbprintreceipt.CheckedChanged += new System.EventHandler(this.cbprintreceipt_CheckedChanged);
            // 
            // btnprintreceiptp
            // 
            this.btnprintreceiptp.Location = new System.Drawing.Point(505, 206);
            this.btnprintreceiptp.Name = "btnprintreceiptp";
            this.btnprintreceiptp.Size = new System.Drawing.Size(135, 23);
            this.btnprintreceiptp.TabIndex = 96;
            this.btnprintreceiptp.Text = "Print Receipt";
            this.btnprintreceiptp.Visible = false;
            this.btnprintreceiptp.Click += new System.EventHandler(this.btnprintreceiptp_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel5.Location = new System.Drawing.Point(9, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(152, 25);
            this.metroLabel5.TabIndex = 94;
            this.metroLabel5.Text = "Hosteller Details";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel4.Location = new System.Drawing.Point(395, 44);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 25);
            this.metroLabel4.TabIndex = 93;
            this.metroLabel4.Text = "Room Details";
            // 
            // txtroomno
            // 
            this.txtroomno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtroomno.CustomBackground = true;
            this.txtroomno.Location = new System.Drawing.Point(669, 88);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(58, 23);
            this.txtroomno.TabIndex = 64;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Silver;
            this.metroLabel10.Location = new System.Drawing.Point(589, 88);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(67, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "Room No";
            // 
            // txtroomid
            // 
            this.txtroomid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtroomid.CustomBackground = true;
            this.txtroomid.Location = new System.Drawing.Point(505, 88);
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.Size = new System.Drawing.Size(58, 23);
            this.txtroomid.TabIndex = 64;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Silver;
            this.metroLabel2.Location = new System.Drawing.Point(425, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 63;
            this.metroLabel2.Text = "Room ID";
            // 
            // txtnationalty
            // 
            this.txtnationalty.Location = new System.Drawing.Point(122, 218);
            this.txtnationalty.Name = "txtnationalty";
            this.txtnationalty.Size = new System.Drawing.Size(222, 23);
            this.txtnationalty.TabIndex = 3;
            // 
            // txtphone
            // 
            this.txtphone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtphone.Location = new System.Drawing.Point(122, 262);
            this.txtphone.Name = "txtphone";
            this.txtphone.PromptText = "(999 999 9999)";
            this.txtphone.Size = new System.Drawing.Size(222, 23);
            this.txtphone.TabIndex = 4;
            // 
            // txtoname
            // 
            this.txtoname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtoname.Location = new System.Drawing.Point(122, 179);
            this.txtoname.Name = "txtoname";
            this.txtoname.PromptText = "Other Name";
            this.txtoname.Size = new System.Drawing.Size(222, 23);
            this.txtoname.TabIndex = 2;
            // 
            // txtlname
            // 
            this.txtlname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtlname.Location = new System.Drawing.Point(122, 132);
            this.txtlname.Name = "txtlname";
            this.txtlname.PromptText = "Last Name";
            this.txtlname.Size = new System.Drawing.Size(222, 23);
            this.txtlname.TabIndex = 1;
            // 
            // txtfname
            // 
            this.txtfname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtfname.Location = new System.Drawing.Point(122, 88);
            this.txtfname.Name = "txtfname";
            this.txtfname.PromptText = "First Name";
            this.txtfname.Size = new System.Drawing.Size(222, 23);
            this.txtfname.TabIndex = 0;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Silver;
            this.metroLabel6.Location = new System.Drawing.Point(9, 179);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 55;
            this.metroLabel6.Text = "Other Name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Silver;
            this.metroLabel7.Location = new System.Drawing.Point(9, 132);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "Last Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Silver;
            this.metroLabel3.Location = new System.Drawing.Point(9, 218);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 57;
            this.metroLabel3.Text = "Nationalty";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Silver;
            this.metroLabel8.Location = new System.Drawing.Point(9, 262);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 58;
            this.metroLabel8.Text = "Phone Number";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Silver;
            this.metroLabel9.Location = new System.Drawing.Point(9, 84);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 59;
            this.metroLabel9.Text = "First Name";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(630, 298);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(97, 23);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnavailableroom
            // 
            this.btnavailableroom.Location = new System.Drawing.Point(505, 132);
            this.btnavailableroom.Name = "btnavailableroom";
            this.btnavailableroom.Size = new System.Drawing.Size(222, 23);
            this.btnavailableroom.TabIndex = 5;
            this.btnavailableroom.Text = "Check Available Room";
            this.btnavailableroom.Click += new System.EventHandler(this.btnavailableroom_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(511, 298);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(103, 23);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(702, 17);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(66, 23);
            this.btnlogout.Style = MetroFramework.MetroColorStyle.Green;
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbltime);
            this.Name = "HomeCashier";
            this.Text = "Cashier\'s Page";
            this.Load += new System.EventHandler(this.HomeCashier_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabavailableroom.ResumeLayout(false);
            this.tabavailableroom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAvailableRoom)).EndInit();
            this.tabnewhosteller.ResumeLayout(false);
            this.tabnewhosteller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbltime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbluser;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabavailableroom;
        private System.Windows.Forms.DataGridView DataGridAvailableRoom;
        private MetroFramework.Controls.MetroTabPage tabnewhosteller;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtnationalty;
        private MetroFramework.Controls.MetroTextBox txtphone;
        private MetroFramework.Controls.MetroTextBox txtoname;
        private MetroFramework.Controls.MetroTextBox txtlname;
        private MetroFramework.Controls.MetroTextBox txtfname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnreset;
        private MetroFramework.Controls.MetroButton btnavailableroom;
        private MetroFramework.Controls.MetroButton btnsubmit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTextBox txtroomid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton btnlogout;
        private System.Windows.Forms.CheckBox cbprintreceipt;
        private MetroFramework.Controls.MetroButton btnprintreceiptp;
        private System.Windows.Forms.Timer timer1;
        public MetroFramework.Controls.MetroTextBox txtroomno;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}