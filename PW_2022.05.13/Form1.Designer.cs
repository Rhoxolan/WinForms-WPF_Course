namespace PW_2022._05._13
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
            this.textBoxDiagram1 = new System.Windows.Forms.TextBox();
            this.textBoxDiagram2 = new System.Windows.Forms.TextBox();
            this.textBoxDiagram3 = new System.Windows.Forms.TextBox();
            this.numericUpDownDiagram1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiagram2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiagram3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagram3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDiagram1
            // 
            this.textBoxDiagram1.Location = new System.Drawing.Point(12, 12);
            this.textBoxDiagram1.Name = "textBoxDiagram1";
            this.textBoxDiagram1.Size = new System.Drawing.Size(92, 23);
            this.textBoxDiagram1.TabIndex = 0;
            this.textBoxDiagram1.Text = "Значение 1";
            // 
            // textBoxDiagram2
            // 
            this.textBoxDiagram2.Location = new System.Drawing.Point(12, 41);
            this.textBoxDiagram2.Name = "textBoxDiagram2";
            this.textBoxDiagram2.Size = new System.Drawing.Size(92, 23);
            this.textBoxDiagram2.TabIndex = 1;
            this.textBoxDiagram2.Text = "Значение 2";
            // 
            // textBoxDiagram3
            // 
            this.textBoxDiagram3.Location = new System.Drawing.Point(12, 70);
            this.textBoxDiagram3.Name = "textBoxDiagram3";
            this.textBoxDiagram3.Size = new System.Drawing.Size(92, 23);
            this.textBoxDiagram3.TabIndex = 2;
            this.textBoxDiagram3.Text = "Значение 3";
            // 
            // numericUpDownDiagram1
            // 
            this.numericUpDownDiagram1.Location = new System.Drawing.Point(110, 13);
            this.numericUpDownDiagram1.Name = "numericUpDownDiagram1";
            this.numericUpDownDiagram1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDiagram1.TabIndex = 3;
            this.numericUpDownDiagram1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiagram1.ValueChanged += new System.EventHandler(this.numericUpDownDiagram1_ValueChanged);
            // 
            // numericUpDownDiagram2
            // 
            this.numericUpDownDiagram2.Location = new System.Drawing.Point(110, 41);
            this.numericUpDownDiagram2.Name = "numericUpDownDiagram2";
            this.numericUpDownDiagram2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDiagram2.TabIndex = 4;
            this.numericUpDownDiagram2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiagram2.ValueChanged += new System.EventHandler(this.numericUpDownDiagram2_ValueChanged);
            // 
            // numericUpDownDiagram3
            // 
            this.numericUpDownDiagram3.Location = new System.Drawing.Point(110, 71);
            this.numericUpDownDiagram3.Name = "numericUpDownDiagram3";
            this.numericUpDownDiagram3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDiagram3.TabIndex = 5;
            this.numericUpDownDiagram3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiagram3.ValueChanged += new System.EventHandler(this.numericUpDownDiagram3_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(508, 107);
            this.Controls.Add(this.numericUpDownDiagram3);
            this.Controls.Add(this.numericUpDownDiagram2);
            this.Controls.Add(this.numericUpDownDiagram1);
            this.Controls.Add(this.textBoxDiagram3);
            this.Controls.Add(this.textBoxDiagram2);
            this.Controls.Add(this.textBoxDiagram1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagram3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDiagram1;
        private TextBox textBoxDiagram2;
        private TextBox textBoxDiagram3;
        private NumericUpDown numericUpDownDiagram1;
        private NumericUpDown numericUpDownDiagram2;
        private NumericUpDown numericUpDownDiagram3;
    }
}