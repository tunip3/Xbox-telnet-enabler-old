namespace Xbox_Telnet_enabler
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
            this.enable = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.TextBox();
            this.host = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vspaircode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(3, 98);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(267, 30);
            this.enable.TabIndex = 0;
            this.enable.Text = "enable telnet";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(3, 29);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(267, 20);
            this.IP.TabIndex = 1;
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.host.Location = new System.Drawing.Point(0, 9);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(258, 17);
            this.host.TabIndex = 2;
            this.host.Text = "Please enter your Xbox hostname or IP.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(0, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter you visual studio pairing pin";
            // 
            // vspaircode
            // 
            this.vspaircode.Location = new System.Drawing.Point(3, 72);
            this.vspaircode.Name = "vspaircode";
            this.vspaircode.Size = new System.Drawing.Size(267, 20);
            this.vspaircode.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 135);
            this.Controls.Add(this.vspaircode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.host);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.enable);
            this.Name = "Xbox Telnet enabler";
            this.Text = "Xbox Telnet enabler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vspaircode;
    }
}

