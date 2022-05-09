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
            this.numericUpDownSomeOther = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWater = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBeer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHotDog = new System.Windows.Forms.NumericUpDown();
            this.textBoxSomeOtherPrice = new System.Windows.Forms.TextBox();
            this.checkBoxSomeOther = new System.Windows.Forms.CheckBox();
            this.textBoxWaterPrice = new System.Windows.Forms.TextBox();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.textBoxBeerPrice = new System.Windows.Forms.TextBox();
            this.checkBoxBeer = new System.Windows.Forms.CheckBox();
            this.textBoxHotDogPrice = new System.Windows.Forms.TextBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.labelLitres = new System.Windows.Forms.Label();
            this.groupBoxCafeSum = new System.Windows.Forms.GroupBox();
            this.CAFESUM = new System.Windows.Forms.Label();
            this.groupBoxTotalAmountPayable = new System.Windows.Forms.GroupBox();
            this.groupBoxPetrol.SuspendLayout();
            this.groupBoxAmountPrice.SuspendLayout();
            this.groupBoxPetrolChecksum.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSomeOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotDog)).BeginInit();
            this.groupBoxCafeSum.SuspendLayout();
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
            this.textBoxInputBenzinPrice.TextChanged += new System.EventHandler(this.textBoxInputBenzinPrice_TextChanged);
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
            this.SUM.Location = new System.Drawing.Point(6, 44);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(105, 45);
            this.SUM.TabIndex = 0;
            this.SUM.Text = "label1";
            this.SUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.numericUpDownSomeOther);
            this.groupBoxCafe.Controls.Add(this.numericUpDownWater);
            this.groupBoxCafe.Controls.Add(this.numericUpDownBeer);
            this.groupBoxCafe.Controls.Add(this.numericUpDownHotDog);
            this.groupBoxCafe.Controls.Add(this.textBoxSomeOtherPrice);
            this.groupBoxCafe.Controls.Add(this.checkBoxSomeOther);
            this.groupBoxCafe.Controls.Add(this.textBoxWaterPrice);
            this.groupBoxCafe.Controls.Add(this.checkBoxWater);
            this.groupBoxCafe.Controls.Add(this.textBoxBeerPrice);
            this.groupBoxCafe.Controls.Add(this.checkBoxBeer);
            this.groupBoxCafe.Controls.Add(this.textBoxHotDogPrice);
            this.groupBoxCafe.Controls.Add(this.checkBoxHotDog);
            this.groupBoxCafe.Controls.Add(this.labelLitres);
            this.groupBoxCafe.Controls.Add(this.groupBoxCafeSum);
            this.groupBoxCafe.Location = new System.Drawing.Point(250, 12);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(232, 308);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Кафе";
            // 
            // numericUpDownSomeOther
            // 
            this.numericUpDownSomeOther.Location = new System.Drawing.Point(153, 109);
            this.numericUpDownSomeOther.Name = "numericUpDownSomeOther";
            this.numericUpDownSomeOther.Size = new System.Drawing.Size(73, 23);
            this.numericUpDownSomeOther.TabIndex = 23;
            this.numericUpDownSomeOther.ValueChanged += new System.EventHandler(this.numericUpDownSomeOther_ValueChanged);
            // 
            // numericUpDownWater
            // 
            this.numericUpDownWater.Location = new System.Drawing.Point(153, 82);
            this.numericUpDownWater.Name = "numericUpDownWater";
            this.numericUpDownWater.Size = new System.Drawing.Size(73, 23);
            this.numericUpDownWater.TabIndex = 22;
            this.numericUpDownWater.ValueChanged += new System.EventHandler(this.numericUpDownWater_ValueChanged);
            // 
            // numericUpDownBeer
            // 
            this.numericUpDownBeer.Location = new System.Drawing.Point(153, 53);
            this.numericUpDownBeer.Name = "numericUpDownBeer";
            this.numericUpDownBeer.Size = new System.Drawing.Size(73, 23);
            this.numericUpDownBeer.TabIndex = 21;
            this.numericUpDownBeer.ValueChanged += new System.EventHandler(this.numericUpDownBeer_ValueChanged);
            // 
            // numericUpDownHotDog
            // 
            this.numericUpDownHotDog.Location = new System.Drawing.Point(153, 22);
            this.numericUpDownHotDog.Name = "numericUpDownHotDog";
            this.numericUpDownHotDog.Size = new System.Drawing.Size(73, 23);
            this.numericUpDownHotDog.TabIndex = 20;
            this.numericUpDownHotDog.ValueChanged += new System.EventHandler(this.numericUpDownHotDog_ValueChanged);
            // 
            // textBoxSomeOtherPrice
            // 
            this.textBoxSomeOtherPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxSomeOtherPrice.Location = new System.Drawing.Point(82, 109);
            this.textBoxSomeOtherPrice.Name = "textBoxSomeOtherPrice";
            this.textBoxSomeOtherPrice.ReadOnly = true;
            this.textBoxSomeOtherPrice.Size = new System.Drawing.Size(65, 23);
            this.textBoxSomeOtherPrice.TabIndex = 19;
            this.textBoxSomeOtherPrice.Text = "100 грн";
            // 
            // checkBoxSomeOther
            // 
            this.checkBoxSomeOther.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSomeOther.Location = new System.Drawing.Point(6, 111);
            this.checkBoxSomeOther.Name = "checkBoxSomeOther";
            this.checkBoxSomeOther.Size = new System.Drawing.Size(70, 35);
            this.checkBoxSomeOther.TabIndex = 18;
            this.checkBoxSomeOther.Text = "Я от Шерифа";
            this.checkBoxSomeOther.UseVisualStyleBackColor = true;
            this.checkBoxSomeOther.CheckedChanged += new System.EventHandler(this.checkBoxSomeOther_CheckedChanged);
            // 
            // textBoxWaterPrice
            // 
            this.textBoxWaterPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxWaterPrice.Location = new System.Drawing.Point(82, 80);
            this.textBoxWaterPrice.Name = "textBoxWaterPrice";
            this.textBoxWaterPrice.ReadOnly = true;
            this.textBoxWaterPrice.Size = new System.Drawing.Size(65, 23);
            this.textBoxWaterPrice.TabIndex = 16;
            this.textBoxWaterPrice.Text = "10 грн";
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Location = new System.Drawing.Point(6, 82);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(52, 19);
            this.checkBoxWater.TabIndex = 15;
            this.checkBoxWater.Text = "Вода";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            this.checkBoxWater.CheckedChanged += new System.EventHandler(this.checkBoxWater_CheckedChanged);
            // 
            // textBoxBeerPrice
            // 
            this.textBoxBeerPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxBeerPrice.Location = new System.Drawing.Point(82, 51);
            this.textBoxBeerPrice.Name = "textBoxBeerPrice";
            this.textBoxBeerPrice.ReadOnly = true;
            this.textBoxBeerPrice.Size = new System.Drawing.Size(65, 23);
            this.textBoxBeerPrice.TabIndex = 13;
            this.textBoxBeerPrice.Text = "30 грн";
            // 
            // checkBoxBeer
            // 
            this.checkBoxBeer.AutoSize = true;
            this.checkBoxBeer.Location = new System.Drawing.Point(6, 53);
            this.checkBoxBeer.Name = "checkBoxBeer";
            this.checkBoxBeer.Size = new System.Drawing.Size(55, 19);
            this.checkBoxBeer.TabIndex = 12;
            this.checkBoxBeer.Text = "Пиво";
            this.checkBoxBeer.UseVisualStyleBackColor = true;
            this.checkBoxBeer.CheckedChanged += new System.EventHandler(this.checkBoxBeer_CheckedChanged);
            // 
            // textBoxHotDogPrice
            // 
            this.textBoxHotDogPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxHotDogPrice.Location = new System.Drawing.Point(82, 22);
            this.textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            this.textBoxHotDogPrice.ReadOnly = true;
            this.textBoxHotDogPrice.Size = new System.Drawing.Size(65, 23);
            this.textBoxHotDogPrice.TabIndex = 10;
            this.textBoxHotDogPrice.Text = "27 грн";
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(6, 24);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(70, 19);
            this.checkBoxHotDog.TabIndex = 9;
            this.checkBoxHotDog.Text = "Хот-Дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
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
            // groupBoxCafeSum
            // 
            this.groupBoxCafeSum.Controls.Add(this.CAFESUM);
            this.groupBoxCafeSum.Location = new System.Drawing.Point(6, 210);
            this.groupBoxCafeSum.Name = "groupBoxCafeSum";
            this.groupBoxCafeSum.Size = new System.Drawing.Size(220, 92);
            this.groupBoxCafeSum.TabIndex = 1;
            this.groupBoxCafeSum.TabStop = false;
            this.groupBoxCafeSum.Text = "К оплате";
            // 
            // CAFESUM
            // 
            this.CAFESUM.AutoSize = true;
            this.CAFESUM.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CAFESUM.Location = new System.Drawing.Point(6, 44);
            this.CAFESUM.Name = "CAFESUM";
            this.CAFESUM.Size = new System.Drawing.Size(105, 45);
            this.CAFESUM.TabIndex = 1;
            this.CAFESUM.Text = "label2";
            this.CAFESUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSomeOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotDog)).EndInit();
            this.groupBoxCafeSum.ResumeLayout(false);
            this.groupBoxCafeSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxPetrol;
        private GroupBox groupBoxCafe;
        private GroupBox groupBoxTotalAmountPayable;
        private GroupBox groupBoxPetrolChecksum;
        private GroupBox groupBoxCafeSum;
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
        private TextBox textBoxSomeOtherPrice;
        private CheckBox checkBoxSomeOther;
        private TextBox textBoxWaterPrice;
        private CheckBox checkBoxWater;
        private TextBox textBoxBeerPrice;
        private CheckBox checkBoxBeer;
        private TextBox textBoxHotDogPrice;
        private CheckBox checkBoxHotDog;
        private Label CAFESUM;
        private NumericUpDown numericUpDownSomeOther;
        private NumericUpDown numericUpDownWater;
        private NumericUpDown numericUpDownBeer;
        private NumericUpDown numericUpDownHotDog;
    }
}