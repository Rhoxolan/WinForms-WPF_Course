namespace PW_2022._05._04
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
            this.textBoxFileText = new System.Windows.Forms.TextBox();
            this.labelTaskOne = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelTaskTwo = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelTaskThree = new System.Windows.Forms.Label();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.labelColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFileText
            // 
            this.textBoxFileText.Location = new System.Drawing.Point(12, 27);
            this.textBoxFileText.Multiline = true;
            this.textBoxFileText.Name = "textBoxFileText";
            this.textBoxFileText.ReadOnly = true;
            this.textBoxFileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileText.Size = new System.Drawing.Size(233, 199);
            this.textBoxFileText.TabIndex = 0;
            // 
            // labelTaskOne
            // 
            this.labelTaskOne.AutoSize = true;
            this.labelTaskOne.Location = new System.Drawing.Point(12, 9);
            this.labelTaskOne.Name = "labelTaskOne";
            this.labelTaskOne.Size = new System.Drawing.Size(61, 15);
            this.labelTaskOne.TabIndex = 1;
            this.labelTaskOne.Text = "Задание 1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 232);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // labelTaskTwo
            // 
            this.labelTaskTwo.AutoSize = true;
            this.labelTaskTwo.Location = new System.Drawing.Point(251, 9);
            this.labelTaskTwo.Name = "labelTaskTwo";
            this.labelTaskTwo.Size = new System.Drawing.Size(61, 15);
            this.labelTaskTwo.TabIndex = 3;
            this.labelTaskTwo.Text = "Задание 2";
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Cyan;
            this.progressBar2.Location = new System.Drawing.Point(251, 27);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(233, 23);
            this.progressBar2.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(251, 56);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Начали!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(490, 144);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(170, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelTaskThree
            // 
            this.labelTaskThree.AutoSize = true;
            this.labelTaskThree.Location = new System.Drawing.Point(490, 9);
            this.labelTaskThree.Name = "labelTaskThree";
            this.labelTaskThree.Size = new System.Drawing.Size(61, 15);
            this.labelTaskThree.TabIndex = 7;
            this.labelTaskThree.Text = "Задание 3";
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(490, 126);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(86, 15);
            this.labelOpacity.TabIndex = 8;
            this.labelOpacity.Text = "Прозрачность";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(715, 9);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 170);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(676, 9);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(33, 15);
            this.labelColor.TabIndex = 10;
            this.labelColor.Text = "Цвет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.labelOpacity);
            this.Controls.Add(this.labelTaskThree);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.labelTaskTwo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelTaskOne);
            this.Controls.Add(this.textBoxFileText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFileText;
        private Label labelTaskOne;
        private ProgressBar progressBar1;
        private Label labelTaskTwo;
        private ProgressBar progressBar2;
        private Button buttonStart;
        private TrackBar trackBar1;
        private Label labelTaskThree;
        private Label labelOpacity;
        private TrackBar trackBar2;
        private Label labelColor;
    }
}