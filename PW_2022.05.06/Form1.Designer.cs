namespace PW_2022._05._06
{
    partial class Form1
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
            this.buttonTaskOne = new System.Windows.Forms.Button();
            this.textBoxTaskOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTaskOne
            // 
            this.buttonTaskOne.Location = new System.Drawing.Point(12, 12);
            this.buttonTaskOne.Name = "buttonTaskOne";
            this.buttonTaskOne.Size = new System.Drawing.Size(128, 34);
            this.buttonTaskOne.TabIndex = 0;
            this.buttonTaskOne.Text = "Начать задание 1!";
            this.buttonTaskOne.UseVisualStyleBackColor = true;
            this.buttonTaskOne.Click += new System.EventHandler(this.buttonTaskOne_Click);
            // 
            // textBoxTaskOne
            // 
            this.textBoxTaskOne.Enabled = false;
            this.textBoxTaskOne.Location = new System.Drawing.Point(12, 52);
            this.textBoxTaskOne.Multiline = true;
            this.textBoxTaskOne.Name = "textBoxTaskOne";
            this.textBoxTaskOne.ReadOnly = true;
            this.textBoxTaskOne.Size = new System.Drawing.Size(128, 123);
            this.textBoxTaskOne.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTaskOne);
            this.Controls.Add(this.buttonTaskOne);
            this.Name = "Form1";
            this.Text = "HomeWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonTaskOne;
        private TextBox textBoxTaskOne;
    }
}