namespace HW_2022._05._04
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
            this.groupBoxPetrol = new System.Windows.Forms.GroupBox();
            this.groupBoxPetrolChecksum = new System.Windows.Forms.GroupBox();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTotalAmountPayable = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxPetrol.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPetrol
            // 
            this.groupBoxPetrol.Controls.Add(this.comboBox1);
            this.groupBoxPetrol.Controls.Add(this.groupBoxPetrolChecksum);
            this.groupBoxPetrol.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPetrol.Name = "groupBoxPetrol";
            this.groupBoxPetrol.Size = new System.Drawing.Size(232, 308);
            this.groupBoxPetrol.TabIndex = 0;
            this.groupBoxPetrol.TabStop = false;
            this.groupBoxPetrol.Text = "АЗС";
            // 
            // groupBoxPetrolChecksum
            // 
            this.groupBoxPetrolChecksum.Location = new System.Drawing.Point(6, 210);
            this.groupBoxPetrolChecksum.Name = "groupBoxPetrolChecksum";
            this.groupBoxPetrolChecksum.Size = new System.Drawing.Size(220, 92);
            this.groupBoxPetrolChecksum.TabIndex = 0;
            this.groupBoxPetrolChecksum.TabStop = false;
            this.groupBoxPetrolChecksum.Text = "К оплате";
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.groupBox1);
            this.groupBoxCafe.Location = new System.Drawing.Point(250, 12);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(232, 308);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Кафе";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "К оплате";
            // 
            // groupBoxTotalAmountPayable
            // 
            this.groupBoxTotalAmountPayable.Location = new System.Drawing.Point(12, 326);
            this.groupBoxTotalAmountPayable.Name = "groupBoxTotalAmountPayable";
            this.groupBoxTotalAmountPayable.Size = new System.Drawing.Size(468, 100);
            this.groupBoxTotalAmountPayable.TabIndex = 2;
            this.groupBoxTotalAmountPayable.TabStop = false;
            this.groupBoxTotalAmountPayable.Text = "Сумма к оплате";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Бензин премиум",
            "Бензин люкс",
            "Бензин стандарт",
            "Бензин эконом",
            "Самогон"});
            this.comboBox1.Location = new System.Drawing.Point(6, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(494, 434);
            this.Controls.Add(this.groupBoxTotalAmountPayable);
            this.Controls.Add(this.groupBoxCafe);
            this.Controls.Add(this.groupBoxPetrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "BestOil";
            this.groupBoxPetrol.ResumeLayout(false);
            this.groupBoxCafe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxPetrol;
        private GroupBox groupBoxCafe;
        private GroupBox groupBoxTotalAmountPayable;
        private GroupBox groupBoxPetrolChecksum;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}