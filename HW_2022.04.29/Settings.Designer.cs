namespace HW_2022._04._29
{
    partial class Settings
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
            this.Label = new System.Windows.Forms.Label();
            this.WAV_Button = new System.Windows.Forms.RadioButton();
            this.MP3_Button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(192, 15);
            this.Label.TabIndex = 0;
            this.Label.Text = "Пожалуйста, выберите исходник:";
            // 
            // WAV_Button
            // 
            this.WAV_Button.AutoSize = true;
            this.WAV_Button.Location = new System.Drawing.Point(12, 27);
            this.WAV_Button.Name = "WAV_Button";
            this.WAV_Button.Size = new System.Drawing.Size(50, 19);
            this.WAV_Button.TabIndex = 1;
            this.WAV_Button.TabStop = true;
            this.WAV_Button.Text = "WAV";
            this.WAV_Button.UseVisualStyleBackColor = true;
            // 
            // MP3_Button
            // 
            this.MP3_Button.AutoSize = true;
            this.MP3_Button.Location = new System.Drawing.Point(12, 52);
            this.MP3_Button.Name = "MP3_Button";
            this.MP3_Button.Size = new System.Drawing.Size(49, 19);
            this.MP3_Button.TabIndex = 2;
            this.MP3_Button.TabStop = true;
            this.MP3_Button.Text = "MP3";
            this.MP3_Button.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 108);
            this.Controls.Add(this.MP3_Button);
            this.Controls.Add(this.WAV_Button);
            this.Controls.Add(this.Label);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label;
        private RadioButton WAV_Button;
        private RadioButton MP3_Button;
    }
}