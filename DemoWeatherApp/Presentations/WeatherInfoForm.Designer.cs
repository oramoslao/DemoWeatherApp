namespace DemoWeatherApp.App
{
    partial class WeatherInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherInfoForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_lat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_lon = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reload)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_lat,
            this.lbl_lon});
            this.statusStrip1.Location = new System.Drawing.Point(0, 170);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(327, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_lat
            // 
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(23, 17);
            this.lbl_lat.Text = "Lat";
            // 
            // lbl_lon
            // 
            this.lbl_lon.Name = "lbl_lon";
            this.lbl_lon.Size = new System.Drawing.Size(27, 17);
            this.lbl_lon.Text = "Lon";
            // 
            // lbl_location
            // 
            this.lbl_location.BackColor = System.Drawing.Color.Transparent;
            this.lbl_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ForeColor = System.Drawing.Color.White;
            this.lbl_location.Location = new System.Drawing.Point(10, 10);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(307, 17);
            this.lbl_location.TabIndex = 3;
            this.lbl_location.Text = "Riobamba, Ecuador";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_temp
            // 
            this.lbl_temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.Color.White;
            this.lbl_temp.Location = new System.Drawing.Point(10, 10);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(287, 76);
            this.lbl_temp.TabIndex = 6;
            this.lbl_temp.Text = "19";
            this.lbl_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_datetime);
            this.panel1.Controls.Add(this.lbl_location);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(327, 170);
            this.panel1.TabIndex = 9;
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.Image = global::DemoWeatherApp.Properties.Resources.refresh_white_24x24;
            this.btn_reload.Location = new System.Drawing.Point(293, 10);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(24, 24);
            this.btn_reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_reload.TabIndex = 11;
            this.btn_reload.TabStop = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_temp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(307, 100);
            this.panel2.TabIndex = 10;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datetime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.Color.White;
            this.lbl_datetime.Location = new System.Drawing.Point(10, 27);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_datetime.Size = new System.Drawing.Size(307, 23);
            this.lbl_datetime.TabIndex = 9;
            this.lbl_datetime.Text = "Thu, June 13 16:02";
            this.lbl_datetime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WeatherInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemoWeatherApp.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(327, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WeatherInfoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Demo Weather";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_reload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.ToolStripStatusLabel lbl_lat;
        private System.Windows.Forms.ToolStripStatusLabel lbl_lon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_reload;
    }
}