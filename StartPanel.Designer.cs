namespace LinesAndBoxes
{
    partial class StartPanel
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
            this.button_start = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_height = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Menu;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Location = new System.Drawing.Point(16, 181);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(87, 31);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "начать";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.Menu;
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Location = new System.Drawing.Point(109, 181);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(94, 31);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "выйти";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(13, 37);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(44, 13);
            this.label_height.TabIndex = 2;
            this.label_height.Text = "высота";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(12, 63);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(45, 13);
            this.label_width.TabIndex = 3;
            this.label_width.Text = "ширина";
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(63, 37);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 20);
            this.textBox_height.TabIndex = 4;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(63, 63);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 20);
            this.textBox_width.TabIndex = 5;
            // 
            // StartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 221);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartPanel";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.StartPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
    }
}