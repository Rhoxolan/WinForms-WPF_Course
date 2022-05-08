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
            this.groupBoxAmountPrice = new System.Windows.Forms.GroupBox();
            this.labelUAH = new System.Windows.Forms.Label();
            this.textBoxBenzinPrice = new System.Windows.Forms.TextBox();
            this.labelBenzinPrice = new System.Windows.Forms.Label();
            this.labelBenzin = new System.Windows.Forms.Label();
            this.comboBoxBenzin = new System.Windows.Forms.ComboBox();
            this.groupBoxPetrolChecksum = new System.Windows.Forms.GroupBox();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTotalAmountPayable = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxPetrol.SuspendLayout();
            this.groupBoxAmountPrice.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPetrol
            // 
            this.groupBoxPetrol.Controls.Add(this.groupBoxAmountPrice);
            this.groupBoxPetrol.Controls.Add(this.labelUAH);
            this.groupBoxPetrol.Controls.Add(this.textBoxBenzinPrice);
            this.groupBoxPetrol.Controls.Add(this.labelBenzinPrice);
            this.groupBoxPetrol.Controls.Add(this.labelBenzin);
            this.groupBoxPetrol.Controls.Add(this.comboBoxBenzin);
            this.groupBoxPetrol.Controls.Add(this.groupBoxPetrolChecksum);
            this.groupBoxPetrol.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPetrol.Name = "groupBoxPetrol";
            this.groupBoxPetrol.Size = new System.Drawing.Size(232, 308);
            this.groupBoxPetrol.TabIndex = 0;
            this.groupBoxPetrol.TabStop = false;
            this.groupBoxPetrol.Text = "АЗС";
            // 
            // groupBoxAmountPrice
            // 
            this.groupBoxAmountPrice.Controls.Add(this.radioButton1);
            this.groupBoxAmountPrice.Location = new System.Drawing.Point(6, 104);
            this.groupBoxAmountPrice.Name = "groupBoxAmountPrice";
            this.groupBoxAmountPrice.Size = new System.Drawing.Size(120, 100);
            this.groupBoxAmountPrice.TabIndex = 6;
            this.groupBoxAmountPrice.TabStop = false;
            // 
            // labelUAH
            // 
            this.labelUAH.AutoSize = true;
            this.labelUAH.Location = new System.Drawing.Point(185, 59);
            this.labelUAH.Name = "labelUAH";
            this.labelUAH.Size = new System.Drawing.Size(26, 15);
            this.labelUAH.TabIndex = 5;
            this.labelUAH.Text = "грн";
            // 
            // textBoxBenzinPrice
            // 
            this.textBoxBenzinPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxBenzinPrice.Location = new System.Drawing.Point(58, 51);
            this.textBoxBenzinPrice.Name = "textBoxBenzinPrice";
            this.textBoxBenzinPrice.ReadOnly = true;
            this.textBoxBenzinPrice.Size = new System.Drawing.Size(121, 23);
            this.textBoxBenzinPrice.TabIndex = 4;
            // 
            // labelBenzinPrice
            // 
            this.labelBenzinPrice.AutoSize = true;
            this.labelBenzinPrice.Location = new System.Drawing.Point(6, 54);
            this.labelBenzinPrice.Name = "labelBenzinPrice";
            this.labelBenzinPrice.Size = new System.Drawing.Size(35, 15);
            this.labelBenzinPrice.TabIndex = 3;
            this.labelBenzinPrice.Text = "Цена";
            // 
            // labelBenzin
            // 
            this.labelBenzin.AutoSize = true;
            this.labelBenzin.Location = new System.Drawing.Point(6, 25);
            this.labelBenzin.Name = "labelBenzin";
            this.labelBenzin.Size = new System.Drawing.Size(46, 15);
            this.labelBenzin.TabIndex = 2;
            this.labelBenzin.Text = "Бензин";
            // 
            // comboBoxBenzin
            // 
            this.comboBoxBenzin.FormattingEnabled = true;
            this.comboBoxBenzin.Items.AddRange(new object[] {
            "Бензин премиум",
            "Бензин люкс",
            "Бензин стандарт",
            "Бензин эконом",
            "Самогон"});
            this.comboBoxBenzin.Location = new System.Drawing.Point(58, 22);
            this.comboBoxBenzin.Name = "comboBoxBenzin";
            this.comboBoxBenzin.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBenzin.TabIndex = 1;
            this.comboBoxBenzin.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenzin_SelectedIndexChanged);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPetrol.ResumeLayout(false);
            this.groupBoxPetrol.PerformLayout();
            this.groupBoxAmountPrice.ResumeLayout(false);
            this.groupBoxAmountPrice.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxPetrol;
        private GroupBox groupBoxCafe;
        private GroupBox groupBoxTotalAmountPayable;
        private GroupBox groupBoxPetrolChecksum;
        private GroupBox groupBox1;
        private ComboBox comboBoxBenzin;
        private Label labelBenzin;
        private Label labelBenzinPrice;
        private Label labelUAH;
        private TextBox textBoxBenzinPrice;
        private GroupBox groupBoxAmountPrice;
        private RadioButton radioButton1;
    }
}