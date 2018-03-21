namespace HostelMgtSys
{
    partial class frmhostellerreport
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
            this.hostrepdataGrid = new System.Windows.Forms.DataGridView();
            this.getDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDataSource = new HostelMgtSys.getDataSource();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblfullname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblroomcat = new MetroFramework.Controls.MetroLabel();
            this.lblamount = new MetroFramework.Controls.MetroLabel();
            this.lblroomid = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblentry = new MetroFramework.Controls.MetroLabel();
            this.lblexpires = new MetroFramework.Controls.MetroLabel();
            this.btnprint = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.roomno = new MetroFramework.Controls.MetroLabel();
            this.lblroomno = new MetroFramework.Controls.MetroLabel();
            this.btnsearch = new MetroFramework.Controls.MetroButton();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hostrepdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hostrepdataGrid
            // 
            this.hostrepdataGrid.AllowUserToOrderColumns = true;
            this.hostrepdataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.hostrepdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostrepdataGrid.Location = new System.Drawing.Point(403, 107);
            this.hostrepdataGrid.Name = "hostrepdataGrid";
            this.hostrepdataGrid.Size = new System.Drawing.Size(398, 245);
            this.hostrepdataGrid.TabIndex = 2;
            this.hostrepdataGrid.Visible = false;
            this.hostrepdataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.hostrepdataGrid_RowEnter_1);
            // 
            // getDataSourceBindingSource
            // 
            this.getDataSourceBindingSource.DataSource = this.getDataSource;
            this.getDataSourceBindingSource.Position = 0;
            // 
            // getDataSource
            // 
            this.getDataSource.DataSetName = "getDataSource";
            this.getDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Full Name";
            this.metroLabel1.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(168, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Category of room ocupied";
            this.metroLabel2.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(197, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Room ID";
            this.metroLabel3.Visible = false;
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.CustomForeColor = true;
            this.lblfullname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblfullname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblfullname.Location = new System.Drawing.Point(110, 107);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(141, 19);
            this.lblfullname.TabIndex = 3;
            this.lblfullname.Text = "Hosteller Full Name";
            this.lblfullname.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 231);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(119, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Amount Paid (Ghc)";
            this.metroLabel5.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 277);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Date Of Entry";
            this.metroLabel6.Visible = false;
            // 
            // lblroomcat
            // 
            this.lblroomcat.AutoSize = true;
            this.lblroomcat.CustomForeColor = true;
            this.lblroomcat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblroomcat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblroomcat.Location = new System.Drawing.Point(197, 146);
            this.lblroomcat.Name = "lblroomcat";
            this.lblroomcat.Size = new System.Drawing.Size(116, 19);
            this.lblroomcat.TabIndex = 3;
            this.lblroomcat.Text = "Room Category";
            this.lblroomcat.Visible = false;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.CustomForeColor = true;
            this.lblamount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblamount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblamount.Location = new System.Drawing.Point(148, 231);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(62, 19);
            this.lblamount.TabIndex = 3;
            this.lblamount.Text = "Amount";
            this.lblamount.Visible = false;
            // 
            // lblroomid
            // 
            this.lblroomid.AutoSize = true;
            this.lblroomid.CustomForeColor = true;
            this.lblroomid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblroomid.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblroomid.Location = new System.Drawing.Point(276, 190);
            this.lblroomid.Name = "lblroomid";
            this.lblroomid.Size = new System.Drawing.Size(67, 19);
            this.lblroomid.TabIndex = 3;
            this.lblroomid.Text = "Room ID";
            this.lblroomid.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 315);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Expiring Date";
            this.metroLabel4.Visible = false;
            // 
            // lblentry
            // 
            this.lblentry.AutoSize = true;
            this.lblentry.CustomForeColor = true;
            this.lblentry.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblentry.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblentry.Location = new System.Drawing.Point(118, 277);
            this.lblentry.Name = "lblentry";
            this.lblentry.Size = new System.Drawing.Size(85, 19);
            this.lblentry.TabIndex = 3;
            this.lblentry.Text = "19/11/2000";
            this.lblentry.Visible = false;
            // 
            // lblexpires
            // 
            this.lblexpires.AutoSize = true;
            this.lblexpires.CustomForeColor = true;
            this.lblexpires.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblexpires.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblexpires.Location = new System.Drawing.Point(116, 315);
            this.lblexpires.Name = "lblexpires";
            this.lblexpires.Size = new System.Drawing.Size(85, 19);
            this.lblexpires.TabIndex = 3;
            this.lblexpires.Text = "19/11/2000";
            this.lblexpires.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(403, 370);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(90, 23);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "Print Report";
            this.btnprint.Visible = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(709, 370);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(93, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Close";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // roomno
            // 
            this.roomno.AutoSize = true;
            this.roomno.Location = new System.Drawing.Point(23, 190);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(67, 19);
            this.roomno.TabIndex = 3;
            this.roomno.Text = "Room No";
            this.roomno.Visible = false;
            // 
            // lblroomno
            // 
            this.lblroomno.AutoSize = true;
            this.lblroomno.CustomForeColor = true;
            this.lblroomno.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblroomno.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblroomno.Location = new System.Drawing.Point(90, 190);
            this.lblroomno.Name = "lblroomno";
            this.lblroomno.Size = new System.Drawing.Size(73, 19);
            this.lblroomno.TabIndex = 3;
            this.lblroomno.Text = "Room No";
            this.lblroomno.Visible = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(727, 69);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // txtsearch
            // 
            this.txtsearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtsearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtsearch.Location = new System.Drawing.Point(405, 69);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PromptText = "Search";
            this.txtsearch.Size = new System.Drawing.Size(305, 23);
            this.txtsearch.TabIndex = 6;
            // 
            // frmhostellerreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 419);
            this.ControlBox = false;
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblroomno);
            this.Controls.Add(this.lblroomid);
            this.Controls.Add(this.lblexpires);
            this.Controls.Add(this.lblentry);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblroomcat);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.roomno);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.hostrepdataGrid);
            this.Name = "frmhostellerreport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hosteller Report";
            this.Load += new System.EventHandler(this.frmhostellerreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostrepdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView hostrepdataGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblfullname;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblroomcat;
        private MetroFramework.Controls.MetroLabel lblamount;
        private MetroFramework.Controls.MetroLabel lblroomid;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblentry;
        private MetroFramework.Controls.MetroLabel lblexpires;
        private MetroFramework.Controls.MetroButton btnprint;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroLabel roomno;
        private MetroFramework.Controls.MetroLabel lblroomno;
        private System.Windows.Forms.BindingSource getDataSourceBindingSource;
        private getDataSource getDataSource;
        private MetroFramework.Controls.MetroButton btnsearch;
        private MetroFramework.Controls.MetroTextBox txtsearch;
    }
}