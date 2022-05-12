namespace HW_2022._05._06
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.buttonCleaned = new System.Windows.Forms.Button();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDayOfTheWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtonLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            this.укрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxPetrol.SuspendLayout();
            this.groupBoxAmountPrice.SuspendLayout();
            this.groupBoxPetrolChecksum.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSomeOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotDog)).BeginInit();
            this.groupBoxCafeSum.SuspendLayout();
            this.groupBoxTotalAmountPayable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPetrol
            // 
            resources.ApplyResources(this.groupBoxPetrol, "groupBoxPetrol");
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
            this.groupBoxPetrol.Name = "groupBoxPetrol";
            this.groupBoxPetrol.TabStop = false;
            // 
            // labelChangeBenzinPrice
            // 
            resources.ApplyResources(this.labelChangeBenzinPrice, "labelChangeBenzinPrice");
            this.labelChangeBenzinPrice.Name = "labelChangeBenzinPrice";
            // 
            // textBoxInputBenzinPrice
            // 
            resources.ApplyResources(this.textBoxInputBenzinPrice, "textBoxInputBenzinPrice");
            this.textBoxInputBenzinPrice.Name = "textBoxInputBenzinPrice";
            this.textBoxInputBenzinPrice.TextChanged += new System.EventHandler(this.textBoxInputBenzinPrice_TextChanged);
            // 
            // labelLitr
            // 
            resources.ApplyResources(this.labelLitr, "labelLitr");
            this.labelLitr.Name = "labelLitr";
            // 
            // textBoxInputBenzinLitres
            // 
            resources.ApplyResources(this.textBoxInputBenzinLitres, "textBoxInputBenzinLitres");
            this.textBoxInputBenzinLitres.Name = "textBoxInputBenzinLitres";
            this.textBoxInputBenzinLitres.TextChanged += new System.EventHandler(this.textBoxInputBenzinLitres_TextChanged);
            // 
            // groupBoxAmountPrice
            // 
            resources.ApplyResources(this.groupBoxAmountPrice, "groupBoxAmountPrice");
            this.groupBoxAmountPrice.Controls.Add(this.radioButtonPrice);
            this.groupBoxAmountPrice.Controls.Add(this.radioButtonAmount);
            this.groupBoxAmountPrice.Name = "groupBoxAmountPrice";
            this.groupBoxAmountPrice.TabStop = false;
            // 
            // radioButtonPrice
            // 
            resources.ApplyResources(this.radioButtonPrice, "radioButtonPrice");
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // radioButtonAmount
            // 
            resources.ApplyResources(this.radioButtonAmount, "radioButtonAmount");
            this.radioButtonAmount.Name = "radioButtonAmount";
            this.radioButtonAmount.TabStop = true;
            this.radioButtonAmount.UseVisualStyleBackColor = true;
            this.radioButtonAmount.CheckedChanged += new System.EventHandler(this.radioButtonAmount_CheckedChanged);
            // 
            // labelUAH
            // 
            resources.ApplyResources(this.labelUAH, "labelUAH");
            this.labelUAH.Name = "labelUAH";
            // 
            // textBoxBenzinPrice
            // 
            resources.ApplyResources(this.textBoxBenzinPrice, "textBoxBenzinPrice");
            this.textBoxBenzinPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxBenzinPrice.Name = "textBoxBenzinPrice";
            this.textBoxBenzinPrice.ReadOnly = true;
            // 
            // labelBenzinPrice
            // 
            resources.ApplyResources(this.labelBenzinPrice, "labelBenzinPrice");
            this.labelBenzinPrice.Name = "labelBenzinPrice";
            // 
            // labelBenzin
            // 
            resources.ApplyResources(this.labelBenzin, "labelBenzin");
            this.labelBenzin.Name = "labelBenzin";
            // 
            // comboBoxBenzin
            // 
            resources.ApplyResources(this.comboBoxBenzin, "comboBoxBenzin");
            this.comboBoxBenzin.FormattingEnabled = true;
            this.comboBoxBenzin.Name = "comboBoxBenzin";
            this.comboBoxBenzin.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenzin_SelectedIndexChanged);
            // 
            // groupBoxPetrolChecksum
            // 
            resources.ApplyResources(this.groupBoxPetrolChecksum, "groupBoxPetrolChecksum");
            this.groupBoxPetrolChecksum.Controls.Add(this.SUM);
            this.groupBoxPetrolChecksum.Name = "groupBoxPetrolChecksum";
            this.groupBoxPetrolChecksum.TabStop = false;
            // 
            // SUM
            // 
            resources.ApplyResources(this.SUM, "SUM");
            this.SUM.Name = "SUM";
            // 
            // groupBoxCafe
            // 
            resources.ApplyResources(this.groupBoxCafe, "groupBoxCafe");
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
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.TabStop = false;
            // 
            // numericUpDownSomeOther
            // 
            resources.ApplyResources(this.numericUpDownSomeOther, "numericUpDownSomeOther");
            this.numericUpDownSomeOther.Name = "numericUpDownSomeOther";
            this.numericUpDownSomeOther.ValueChanged += new System.EventHandler(this.numericUpDownSomeOther_ValueChanged);
            // 
            // numericUpDownWater
            // 
            resources.ApplyResources(this.numericUpDownWater, "numericUpDownWater");
            this.numericUpDownWater.Name = "numericUpDownWater";
            this.numericUpDownWater.ValueChanged += new System.EventHandler(this.numericUpDownWater_ValueChanged);
            // 
            // numericUpDownBeer
            // 
            resources.ApplyResources(this.numericUpDownBeer, "numericUpDownBeer");
            this.numericUpDownBeer.Name = "numericUpDownBeer";
            this.numericUpDownBeer.ValueChanged += new System.EventHandler(this.numericUpDownBeer_ValueChanged);
            // 
            // numericUpDownHotDog
            // 
            resources.ApplyResources(this.numericUpDownHotDog, "numericUpDownHotDog");
            this.numericUpDownHotDog.Name = "numericUpDownHotDog";
            this.numericUpDownHotDog.ValueChanged += new System.EventHandler(this.numericUpDownHotDog_ValueChanged);
            // 
            // textBoxSomeOtherPrice
            // 
            resources.ApplyResources(this.textBoxSomeOtherPrice, "textBoxSomeOtherPrice");
            this.textBoxSomeOtherPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxSomeOtherPrice.Name = "textBoxSomeOtherPrice";
            this.textBoxSomeOtherPrice.ReadOnly = true;
            // 
            // checkBoxSomeOther
            // 
            resources.ApplyResources(this.checkBoxSomeOther, "checkBoxSomeOther");
            this.checkBoxSomeOther.Name = "checkBoxSomeOther";
            this.checkBoxSomeOther.UseVisualStyleBackColor = true;
            this.checkBoxSomeOther.CheckedChanged += new System.EventHandler(this.checkBoxSomeOther_CheckedChanged);
            // 
            // textBoxWaterPrice
            // 
            resources.ApplyResources(this.textBoxWaterPrice, "textBoxWaterPrice");
            this.textBoxWaterPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxWaterPrice.Name = "textBoxWaterPrice";
            this.textBoxWaterPrice.ReadOnly = true;
            // 
            // checkBoxWater
            // 
            resources.ApplyResources(this.checkBoxWater, "checkBoxWater");
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            this.checkBoxWater.CheckedChanged += new System.EventHandler(this.checkBoxWater_CheckedChanged);
            // 
            // textBoxBeerPrice
            // 
            resources.ApplyResources(this.textBoxBeerPrice, "textBoxBeerPrice");
            this.textBoxBeerPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxBeerPrice.Name = "textBoxBeerPrice";
            this.textBoxBeerPrice.ReadOnly = true;
            // 
            // checkBoxBeer
            // 
            resources.ApplyResources(this.checkBoxBeer, "checkBoxBeer");
            this.checkBoxBeer.Name = "checkBoxBeer";
            this.checkBoxBeer.UseVisualStyleBackColor = true;
            this.checkBoxBeer.CheckedChanged += new System.EventHandler(this.checkBoxBeer_CheckedChanged);
            // 
            // textBoxHotDogPrice
            // 
            resources.ApplyResources(this.textBoxHotDogPrice, "textBoxHotDogPrice");
            this.textBoxHotDogPrice.BackColor = System.Drawing.Color.OldLace;
            this.textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            this.textBoxHotDogPrice.ReadOnly = true;
            // 
            // checkBoxHotDog
            // 
            resources.ApplyResources(this.checkBoxHotDog, "checkBoxHotDog");
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // labelLitres
            // 
            resources.ApplyResources(this.labelLitres, "labelLitres");
            this.labelLitres.Name = "labelLitres";
            // 
            // groupBoxCafeSum
            // 
            resources.ApplyResources(this.groupBoxCafeSum, "groupBoxCafeSum");
            this.groupBoxCafeSum.Controls.Add(this.CAFESUM);
            this.groupBoxCafeSum.Name = "groupBoxCafeSum";
            this.groupBoxCafeSum.TabStop = false;
            // 
            // CAFESUM
            // 
            resources.ApplyResources(this.CAFESUM, "CAFESUM");
            this.CAFESUM.Name = "CAFESUM";
            // 
            // groupBoxTotalAmountPayable
            // 
            resources.ApplyResources(this.groupBoxTotalAmountPayable, "groupBoxTotalAmountPayable");
            this.groupBoxTotalAmountPayable.Controls.Add(this.buttonCleaned);
            this.groupBoxTotalAmountPayable.Controls.Add(this.labelTotalSum);
            this.groupBoxTotalAmountPayable.Controls.Add(this.buttonCalc);
            this.groupBoxTotalAmountPayable.Controls.Add(this.pictureBox1);
            this.groupBoxTotalAmountPayable.Name = "groupBoxTotalAmountPayable";
            this.groupBoxTotalAmountPayable.TabStop = false;
            // 
            // buttonCleaned
            // 
            resources.ApplyResources(this.buttonCleaned, "buttonCleaned");
            this.buttonCleaned.Name = "buttonCleaned";
            this.buttonCleaned.UseVisualStyleBackColor = true;
            this.buttonCleaned.Click += new System.EventHandler(this.buttonCleaned_Click);
            // 
            // labelTotalSum
            // 
            resources.ApplyResources(this.labelTotalSum, "labelTotalSum");
            this.labelTotalSum.Name = "labelTotalSum";
            // 
            // buttonCalc
            // 
            resources.ApplyResources(this.buttonCalc, "buttonCalc");
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::HW_2022._05._06.Properties.Resources.printer_receipt_simple_icon_cut_circle_with_gray_and_blue_lay_400_152633061;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelDayOfTheWeek,
            this.toolStripDropDownButtonLanguage});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            resources.ApplyResources(this.toolStripStatusLabelTime, "toolStripStatusLabelTime");
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            // 
            // toolStripStatusLabelDayOfTheWeek
            // 
            resources.ApplyResources(this.toolStripStatusLabelDayOfTheWeek, "toolStripStatusLabelDayOfTheWeek");
            this.toolStripStatusLabelDayOfTheWeek.Name = "toolStripStatusLabelDayOfTheWeek";
            // 
            // toolStripDropDownButtonLanguage
            // 
            resources.ApplyResources(this.toolStripDropDownButtonLanguage, "toolStripDropDownButtonLanguage");
            this.toolStripDropDownButtonLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.укрToolStripMenuItem,
            this.русToolStripMenuItem});
            this.toolStripDropDownButtonLanguage.Name = "toolStripDropDownButtonLanguage";
            // 
            // укрToolStripMenuItem
            // 
            resources.ApplyResources(this.укрToolStripMenuItem, "укрToolStripMenuItem");
            this.укрToolStripMenuItem.Name = "укрToolStripMenuItem";
            this.укрToolStripMenuItem.Click += new System.EventHandler(this.укрToolStripMenuItem_Click);
            // 
            // русToolStripMenuItem
            // 
            resources.ApplyResources(this.русToolStripMenuItem, "русToolStripMenuItem");
            this.русToolStripMenuItem.Name = "русToolStripMenuItem";
            this.русToolStripMenuItem.Click += new System.EventHandler(this.русToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxPetrol);
            this.Controls.Add(this.groupBoxTotalAmountPayable);
            this.Controls.Add(this.groupBoxCafe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
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
            this.groupBoxTotalAmountPayable.ResumeLayout(false);
            this.groupBoxTotalAmountPayable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox pictureBox1;
        private Button buttonCalc;
        private Label labelTotalSum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonCleaned;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelTime;
        private ToolStripStatusLabel toolStripStatusLabelDayOfTheWeek;
        private ToolStripDropDownButton toolStripDropDownButtonLanguage;
        private ToolStripMenuItem укрToolStripMenuItem;
        private ToolStripMenuItem русToolStripMenuItem;
        private NotifyIcon notifyIcon1;
    }
}