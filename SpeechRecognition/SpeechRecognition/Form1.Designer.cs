namespace SpeechRecognition
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ENABLE = new System.Windows.Forms.Button();
            this.DISABLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 195);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "-HELLO-";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ENABLE
            // 
            this.ENABLE.Location = new System.Drawing.Point(12, 230);
            this.ENABLE.Name = "ENABLE";
            this.ENABLE.Size = new System.Drawing.Size(131, 36);
            this.ENABLE.TabIndex = 1;
            this.ENABLE.Text = "EnableVoiceControl";
            this.ENABLE.UseVisualStyleBackColor = true;
            this.ENABLE.Click += new System.EventHandler(this.ENABLE_Click);
            // 
            // DISABLE
            // 
            this.DISABLE.Enabled = false;
            this.DISABLE.Location = new System.Drawing.Point(225, 230);
            this.DISABLE.Name = "DISABLE";
            this.DISABLE.Size = new System.Drawing.Size(131, 36);
            this.DISABLE.TabIndex = 2;
            this.DISABLE.Text = "DisableVoiceControl";
            this.DISABLE.UseVisualStyleBackColor = true;
            this.DISABLE.Click += new System.EventHandler(this.DISABLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 278);
            this.Controls.Add(this.DISABLE);
            this.Controls.Add(this.ENABLE);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chitty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ENABLE;
        private System.Windows.Forms.Button DISABLE;
    }
}

