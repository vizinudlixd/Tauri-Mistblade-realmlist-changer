namespace Wow_realmlist_changer
{
    partial class Mainwindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetToTauri = new System.Windows.Forms.Button();
            this.SetToMistblade = new System.Windows.Forms.Button();
            this.infobox = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.Launch = new System.Windows.Forms.Button();
            this.autoShutdown = new System.Windows.Forms.CheckBox();
            this.Is32bit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SetToTauri
            // 
            this.SetToTauri.AutoSize = true;
            this.SetToTauri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetToTauri.ForeColor = System.Drawing.Color.White;
            this.SetToTauri.Location = new System.Drawing.Point(38, 28);
            this.SetToTauri.Name = "SetToTauri";
            this.SetToTauri.Size = new System.Drawing.Size(97, 70);
            this.SetToTauri.TabIndex = 0;
            this.SetToTauri.Text = "SetToTauri";
            this.SetToTauri.UseVisualStyleBackColor = true;
            this.SetToTauri.Click += new System.EventHandler(this.SetToTauri_Click);
            // 
            // SetToMistblade
            // 
            this.SetToMistblade.AutoSize = true;
            this.SetToMistblade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetToMistblade.ForeColor = System.Drawing.Color.White;
            this.SetToMistblade.Location = new System.Drawing.Point(268, 28);
            this.SetToMistblade.Name = "SetToMistblade";
            this.SetToMistblade.Size = new System.Drawing.Size(99, 70);
            this.SetToMistblade.TabIndex = 1;
            this.SetToMistblade.Text = "SetToMistblade";
            this.SetToMistblade.UseVisualStyleBackColor = true;
            this.SetToMistblade.Click += new System.EventHandler(this.SetToMistblade_Click);
            // 
            // infobox
            // 
            this.infobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infobox.ForeColor = System.Drawing.Color.White;
            this.infobox.Location = new System.Drawing.Point(38, 130);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(329, 23);
            this.infobox.TabIndex = 2;
            this.infobox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Black;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.ForeColor = System.Drawing.Color.White;
            this.input.Location = new System.Drawing.Point(38, 104);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(329, 23);
            this.input.TabIndex = 3;
            this.input.Text = "path (eg. C:\\World of Warcraft\\WTF\\Config.wtf";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Launch
            // 
            this.Launch.AutoSize = true;
            this.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Launch.ForeColor = System.Drawing.Color.White;
            this.Launch.Location = new System.Drawing.Point(152, 28);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(99, 70);
            this.Launch.TabIndex = 4;
            this.Launch.Text = "Launch wow";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // autoShutdown
            // 
            this.autoShutdown.AutoSize = true;
            this.autoShutdown.ForeColor = System.Drawing.Color.White;
            this.autoShutdown.Location = new System.Drawing.Point(38, 156);
            this.autoShutdown.Name = "autoShutdown";
            this.autoShutdown.Size = new System.Drawing.Size(161, 19);
            this.autoShutdown.TabIndex = 5;
            this.autoShutdown.Text = "Auto shutdown after start";
            this.autoShutdown.UseVisualStyleBackColor = true;
            // 
            // Is32bit
            // 
            this.Is32bit.AutoSize = true;
            this.Is32bit.ForeColor = System.Drawing.Color.White;
            this.Is32bit.Location = new System.Drawing.Point(38, 180);
            this.Is32bit.Name = "Is32bit";
            this.Is32bit.Size = new System.Drawing.Size(102, 19);
            this.Is32bit.TabIndex = 6;
            this.Is32bit.Text = "Client is 32-bit";
            this.Is32bit.UseVisualStyleBackColor = true;
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 211);
            this.Controls.Add(this.Is32bit);
            this.Controls.Add(this.autoShutdown);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.input);
            this.Controls.Add(this.infobox);
            this.Controls.Add(this.SetToMistblade);
            this.Controls.Add(this.SetToTauri);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 250);
            this.Name = "Mainwindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Mainwindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SetToTauri;
        private Button SetToMistblade;
        private Label infobox;
        private TextBox input;
        private Button Launch;
        private CheckBox autoShutdown;
        private CheckBox Is32bit;
    }
}