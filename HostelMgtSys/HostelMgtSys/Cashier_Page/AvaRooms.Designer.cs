namespace HostelMgtSys.Cashier_Page
{
    partial class AvaRooms
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
            this.RoomsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgridroomno = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.txtgridroom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsGrid
            // 
            this.RoomsGrid.AllowUserToAddRows = false;
            this.RoomsGrid.AllowUserToDeleteRows = false;
            this.RoomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsGrid.Location = new System.Drawing.Point(23, 63);
            this.RoomsGrid.Name = "RoomsGrid";
            this.RoomsGrid.ReadOnly = true;
            this.RoomsGrid.Size = new System.Drawing.Size(338, 322);
            this.RoomsGrid.TabIndex = 4;
            this.RoomsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsGrid_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room No";
            // 
            // txtgridroomno
            // 
            this.txtgridroomno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtgridroomno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgridroomno.Location = new System.Drawing.Point(284, 405);
            this.txtgridroomno.Name = "txtgridroomno";
            this.txtgridroomno.Size = new System.Drawing.Size(78, 23);
            this.txtgridroomno.TabIndex = 8;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(282, 442);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(79, 33);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(23, 442);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(82, 33);
            this.btnselect.TabIndex = 7;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtgridroom
            // 
            this.txtgridroom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtgridroom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgridroom.Location = new System.Drawing.Point(96, 405);
            this.txtgridroom.Name = "txtgridroom";
            this.txtgridroom.Size = new System.Drawing.Size(78, 23);
            this.txtgridroom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room ID";
            // 
            // AvaRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 484);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgridroom);
            this.Controls.Add(this.txtgridroomno);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.RoomsGrid);
            this.MaximizeBox = false;
            this.Name = "AvaRooms";
            this.ShowIcon = false;
            this.Text = "Available Rooms";
            this.Load += new System.EventHandler(this.AvaRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgridroomno;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtgridroom;
        private System.Windows.Forms.Label label2;
    }
}