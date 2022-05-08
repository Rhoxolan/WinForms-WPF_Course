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
            this.labelChangeBenzinPrice = new System.Windows.Forms.Label();
            this.textBoxInputBenzinPrice = new System.Windows.Forms.TextBox();
            this.labelLitr = new System.Windows.Forms.Label();
            this.textBoxInputBenzinLitres = new System.Windows.Forms.TextBox();
            this.groupBoxAmountPrice = new System.Windows.Forms.GroupBox();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonAmount = new System.Windows.Forms.RadioButton();
            this.labelUAH = new System.Windows.Forms.Label();
            this.textBoxBenzinPrice = new System.Windows.Forms.TextBox();
            this.labelBenzinPrice = new System.Windows.Forms.Label();
            this.labelBenzin = new System.Windows.Forms.Label();
            this.comboBoxBenzin = new System.Windows.Forms.ComboBox();
            this.groupBoxPetrolChecksum = new System.Windows.Forms.GroupBox();
            this.SUM = new System.Windows.Forms.Label();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.labelLitres = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTotalAmountPayable = new System.Windows.Forms.GroupBox();
            this.groupBoxPetrol.SuspendLayout();
            this.groupBoxAmountPrice.SuspendLayout();
            this.groupBoxPetrolChecksum.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPetrol
            // 
            this.groupBoxPetrol.Controls.Add(this.labelChangeBenzinPrice);
            this.groupBoxPetrol.Controls.Add(this.textBoxInputBenzinPrice);
            this.groupBoxPetrol.Controls.Add(this.labelLitr);
            this.groupBoxPetrol.Controls.Add(this.textBoxInputBenzinLitres);
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
            // labelChangeBenzinPrice
            // 
            this.labelChangeBenzinPrice.AutoSize = true;
            this.labelChangeBenzinPrice.Location = new System.Drawing.Point(200, 135);
            this.labelChangeBenzinPrice.Name = "labelChangeBenzinPrice";
            this.labelChangeBenzinPrice.Size = new System.Drawing.Size(26, 15);
            this.labelChangeBenzinPrice.TabIndex = 10;
            this.labelChangeBenzinPrice.Text = "грн";
            // 
            // textBoxInputBenzinPrice
            // 
            this.textBoxInputBenzinPrice.Location = new System.Drawing.Point(132, 127);
            this.textBoxInputBenzinPrice.Name = "textBoxInputBenzinPrice";
            this.textBoxInputBenzinPrice.Size = new System.Drawing.Size(62, 23);
            this.textBoxInputBenzinPrice.TabIndex = 9;
            // 
            // labelLitr
            // 
            this.labelLitr.AutoSize = true;
            this.labelLitr.Location = new System.Drawing.Point(200, 106);
            this.labelLitr.Name = "labelLitr";
            this.labelLitr.Size = new System.Drawing.Size(17, 15);
            this.labelLitr.TabIndex = 8;
            this.labelLitr.Text = "л.";
            // 
            // textBoxInputBenzinLitres
            // 
            this.textBoxInputBenzinLitres.Location = new System.Drawing.Point(132, 98);
            this.textBoxInputBenzinLitres.Name = "textBoxInputBenzinLitres";
            this.textBoxInputBenzinLitres.Size = new System.Drawing.Size(62, 23);
            this.textBoxInputBenzinLitres.TabIndex = 7;
            this.textBoxInputBenzinLitres.TextChanged += new System.EventHandler(this.textBoxInputBenzinLitres_TextChanged);
            // 
            // groupBoxAmountPrice
            // 
            this.groupBoxAmountPrice.Controls.Add(this.radioButtonPrice);
            this.groupBoxAmountPrice.Controls.Add(this.radioButtonAmount);
            this.groupBoxAmountPrice.Location = new System.Drawing.Point(6, 80);
            this.groupBoxAmountPrice.Name = "groupBoxAmountPrice";
            this.groupBoxAmountPrice.Size = new System.Drawing.Size(120, 124);
            this.groupBoxAmountPrice.TabIndex = 6;
            this.groupBoxAmountPrice.TabStop = false;
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Location = new System.Drawing.Point(6, 47);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(53, 19);
            this.radioButtonPrice.TabIndex = 3;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Цена";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // radioButtonAmount
            // 
            this.radioButtonAmount.AutoSize = true;
            this.radioButtonAmount.Location = new System.Drawing.Point(6, 22);
            this.radioButtonAmount.Name = "radioButtonAmount";
            this.radioButtonAmount.Size = new System.Drawing.Size(90, 19);
            this.radioButtonAmount.TabIndex = 2;
            this.radioButtonAmount.TabStop = true;
            this.radioButtonAmount.Text = "Количество";
            this.radioButtonAmount.UseVisualStyleBackColor = true;
            this.radioButtonAmount.CheckedChanged += new System.EventHandler(this.radioButtonAmount_CheckedChanged);
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
            this.groupBoxPetrolChecksum.Controls.Add(this.SUM);
            this.groupBoxPetrolChecksum.Location = new System.Drawing.Point(6, 210);
            this.groupBoxPetrolChecksum.Name = "groupBoxPetrolChecksum";
            this.groupBoxPetrolChecksum.Size = new System.Drawing.Size(220, 92);
            this.groupBoxPetrolChecksum.TabIndex = 0;
            this.groupBoxPetrolChecksum.TabStop = false;
            this.groupBoxPetrolChecksum.Text = "К оплате";
            // 
            // SUM
            // 
            this.SUM.AutoSize = true;
            this.SUM.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SUM.Location = new System.Drawing.Point(109, 44);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(105, 45);
            this.SUM.TabIndex = 0;
            this.SUM.Text = "label1";
            this.SUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.labelLitres);
            this.groupBoxCafe.Controls.Add(this.groupBox1);
            this.groupBoxCafe.Location = new System.Drawing.Point(250, 12);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(232, 308);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Кафе";
            // 
            // labelLitres
            // 
            this.labelLitres.AutoSize = true;
            this.labelLitres.Location = new System.Drawing.Point(-21, 106);
            this.labelLitres.Name = "labelLitres";
            this.labelLitres.Size = new System.Drawing.Size(17, 15);
            this.labelLitres.TabIndex = 8;
            this.labelLitres.Text = "л.";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(494, 434);
            this.Controls.Add(this.groupBoxPetrol);
            this.Controls.Add(this.groupBoxTotalAmountPayable);
            this.Controls.Add(this.groupBoxCafe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPetrol.ResumeLayout(false);
            this.groupBoxPetrol.PerformLayout();
            this.groupBoxAmountPrice.ResumeLayout(false);
            this.groupBoxAmountPrice.PerformLayout();
            this.groupBoxPetrolChecksum.ResumeLayout(false);
            this.groupBoxPetrolChecksum.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.groupBoxCafe.PerformLayout();
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
        private RadioButton radioButtonAmount;
        private RadioButton radioButtonPrice;
        private TextBox textBoxInputBenzinLitres;
        private Label labelLitres;
        private Label labelLitr;
        private Label labelChangeBenzinPrice;
        private TextBox textBoxInputBenzinPrice;
        private Label SUM;
    }
}