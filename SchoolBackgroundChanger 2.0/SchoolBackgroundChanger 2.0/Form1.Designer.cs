namespace SchoolBackgroundChanger_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.text_path = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress_done = new MetroFramework.Controls.MetroProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_updateStatus = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(208, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Made by: Aleksander and Thomas";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button1.Location = new System.Drawing.Point(23, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_path
            // 
            this.text_path.Location = new System.Drawing.Point(23, 73);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(377, 23);
            this.text_path.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_path.TabIndex = 11;
            this.text_path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.text_path.UseStyleColors = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button2.Location = new System.Drawing.Point(404, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Browse";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.progress_done);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.panel1.Location = new System.Drawing.Point(23, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 1);
            this.panel1.TabIndex = 14;
            // 
            // progress_done
            // 
            this.progress_done.Location = new System.Drawing.Point(0, -22);
            this.progress_done.Name = "progress_done";
            this.progress_done.Size = new System.Drawing.Size(456, 16);
            this.progress_done.Style = MetroFramework.MetroColorStyle.Blue;
            this.progress_done.TabIndex = 0;
            this.progress_done.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button3.Location = new System.Drawing.Point(23, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Update";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button4.Location = new System.Drawing.Point(404, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Changelog";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_updateStatus
            // 
            this.label_updateStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_updateStatus.Location = new System.Drawing.Point(106, 157);
            this.label_updateStatus.Name = "label_updateStatus";
            this.label_updateStatus.Size = new System.Drawing.Size(294, 23);
            this.label_updateStatus.Style = MetroFramework.MetroColorStyle.Blue;
            this.label_updateStatus.TabIndex = 18;
            this.label_updateStatus.Text = "metroLabel1";
            this.label_updateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_updateStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_updateStatus.UseStyleColors = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.CustomBackground = true;
            this.metroCheckBox1.CustomForeColor = true;
            this.metroCheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroCheckBox1.Location = new System.Drawing.Point(23, 129);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(249, 15);
            this.metroCheckBox1.TabIndex = 20;
            this.metroCheckBox1.Text = "Scale image to fit screen ( Fixes black bars )";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseStyleColors = true;
            this.metroCheckBox1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(23, 180);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(456, 18);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 207);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.label_updateStatus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "School Background Changer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox text_path;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroProgressBar progress_done;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroLabel label_updateStatus;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWelcome;
    }
}

