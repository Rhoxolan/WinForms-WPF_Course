namespace PW_2022._05._06
{
    partial class FormTaskTwo
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
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 9);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(34, 15);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ФИО";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFullName.Location = new System.Drawing.Point(12, 27);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(255, 55);
            this.textBoxFullName.TabIndex = 1;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(12, 85);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(81, 15);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "ГодРождения";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(12, 103);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(255, 23);
            this.numericUpDownYear.TabIndex = 3;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 129);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(32, 15);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Рост";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(12, 147);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(255, 23);
            this.numericUpDownHeight.TabIndex = 5;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonTransfer.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTransfer.Location = new System.Drawing.Point(12, 176);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(255, 106);
            this.buttonTransfer.TabIndex = 6;
            this.buttonTransfer.Text = "Передать";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // FormTaskTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 294);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTaskTwo";
            this.Text = "FormTaskTwo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelDateOfBirth;
        private NumericUpDown numericUpDownYear;
        private Label labelHeight;
        private NumericUpDown numericUpDownHeight;
        private Button buttonTransfer;
    }
}