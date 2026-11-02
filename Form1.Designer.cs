namespace PlaneGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbPlane = new System.Windows.Forms.PictureBox();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.btnEnis = new System.Windows.Forms.Button();
            this.btnTurbulans = new System.Windows.Forms.Button();
            this.btnKemerler = new System.Windows.Forms.Button();
            this.btnTesekkurler = new System.Windows.Forms.Button();
            this.btnBeep = new System.Windows.Forms.Button();
            this.btnGas = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DimGray;
            this.panelLeft.Controls.Add(this.pbLight);
            this.panelLeft.Controls.Add(this.pbPlane);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(320, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // pbLight
            // 
            this.pbLight.BackColor = System.Drawing.Color.Transparent;
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.Location = new System.Drawing.Point(135, 290);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(50, 50);
            this.pbLight.TabIndex = 1;
            this.pbLight.TabStop = false;
            // 
            // pbPlane
            // 
            this.pbPlane.BackColor = System.Drawing.Color.Transparent;
            this.pbPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlane.Location = new System.Drawing.Point(85, 330);
            this.pbPlane.Name = "pbPlane";
            this.pbPlane.Size = new System.Drawing.Size(150, 150);
            this.pbPlane.TabIndex = 0;
            this.pbPlane.TabStop = false;
            // 
            // btnEnis
            // 
            this.btnEnis.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnis.ForeColor = System.Drawing.Color.Black;
            this.btnEnis.Location = new System.Drawing.Point(340, 20);
            this.btnEnis.Name = "btnEnis";
            this.btnEnis.Size = new System.Drawing.Size(240, 45);
            this.btnEnis.TabIndex = 1;
            this.btnEnis.Text = "Eniş hazırlığı";
            this.btnEnis.UseVisualStyleBackColor = false;
            this.btnEnis.Click += new System.EventHandler(this.btnEnis_Click);
            // 
            // btnTurbulans
            // 
            this.btnTurbulans.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTurbulans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurbulans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTurbulans.ForeColor = System.Drawing.Color.Black;
            this.btnTurbulans.Location = new System.Drawing.Point(340, 75);
            this.btnTurbulans.Name = "btnTurbulans";
            this.btnTurbulans.Size = new System.Drawing.Size(240, 45);
            this.btnTurbulans.TabIndex = 2;
            this.btnTurbulans.Text = "Turbulans";
            this.btnTurbulans.UseVisualStyleBackColor = false;
            this.btnTurbulans.Click += new System.EventHandler(this.btnTurbulans_Click);
            // 
            // btnKemerler
            // 
            this.btnKemerler.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKemerler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKemerler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKemerler.ForeColor = System.Drawing.Color.Black;
            this.btnKemerler.Location = new System.Drawing.Point(340, 130);
            this.btnKemerler.Name = "btnKemerler";
            this.btnKemerler.Size = new System.Drawing.Size(240, 45);
            this.btnKemerler.TabIndex = 3;
            this.btnKemerler.Text = "Kəmərlər";
            this.btnKemerler.UseVisualStyleBackColor = false;
            this.btnKemerler.Click += new System.EventHandler(this.btnKemerler_Click);
            // 
            // btnTesekkurler
            // 
            this.btnTesekkurler.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTesekkurler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesekkurler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTesekkurler.ForeColor = System.Drawing.Color.Black;
            this.btnTesekkurler.Location = new System.Drawing.Point(340, 185);
            this.btnTesekkurler.Name = "btnTesekkurler";
            this.btnTesekkurler.Size = new System.Drawing.Size(240, 45);
            this.btnTesekkurler.TabIndex = 4;
            this.btnTesekkurler.Text = "Təşəkkürlər";
            this.btnTesekkurler.UseVisualStyleBackColor = false;
            this.btnTesekkurler.Click += new System.EventHandler(this.btnTesekkurler_Click);
            // 
            // btnBeep
            // 
            this.btnBeep.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBeep.ForeColor = System.Drawing.Color.Black;
            this.btnBeep.Location = new System.Drawing.Point(340, 240);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(240, 45);
            this.btnBeep.TabIndex = 5;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = false;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // btnGas
            // 
            this.btnGas.BackColor = System.Drawing.Color.Green;
            this.btnGas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnGas.ForeColor = System.Drawing.Color.White;
            this.btnGas.Location = new System.Drawing.Point(340, 320);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(115, 65);
            this.btnGas.TabIndex = 6;
            this.btnGas.Text = "GAS";
            this.btnGas.UseVisualStyleBackColor = false;
            this.btnGas.Click += new System.EventHandler(this.btnGas_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.DarkRed;
            this.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBreak.ForeColor = System.Drawing.Color.White;
            this.btnBreak.Location = new System.Drawing.Point(465, 320);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(115, 65);
            this.btnBreak.TabIndex = 7;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.MediumBlue;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.Location = new System.Drawing.Point(340, 400);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(240, 45);
            this.btnOnOff.TabIndex = 8;
            this.btnOnOff.Text = "ON/OFF";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnGas);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.btnTesekkurler);
            this.Controls.Add(this.btnKemerler);
            this.Controls.Add(this.btnTurbulans);
            this.Controls.Add(this.btnEnis);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plane";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbPlane;
        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Button btnEnis;
        private System.Windows.Forms.Button btnTurbulans;
        private System.Windows.Forms.Button btnKemerler;
        private System.Windows.Forms.Button btnTesekkurler;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Timer timer1;
    }
}
