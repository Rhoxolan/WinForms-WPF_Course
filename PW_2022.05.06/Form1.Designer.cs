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
            this.textBoxTaskTwo = new System.Windows.Forms.TextBox();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.labelTaskThree = new System.Windows.Forms.Label();
            this.listBoxTaskThree = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
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
            // textBoxTaskTwo
            // 
            this.textBoxTaskTwo.Enabled = false;
            this.textBoxTaskTwo.Location = new System.Drawing.Point(146, 52);
            this.textBoxTaskTwo.Multiline = true;
            this.textBoxTaskTwo.Name = "textBoxTaskTwo";
            this.textBoxTaskTwo.ReadOnly = true;
            this.textBoxTaskTwo.Size = new System.Drawing.Size(128, 123);
            this.textBoxTaskTwo.TabIndex = 3;
            // 
            // buttonTask2
            // 
            this.buttonTask2.Location = new System.Drawing.Point(146, 12);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(128, 34);
            this.buttonTask2.TabIndex = 2;
            this.buttonTask2.Text = "Начать задание 2!";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // labelTaskThree
            // 
            this.labelTaskThree.Location = new System.Drawing.Point(280, 12);
            this.labelTaskThree.Name = "labelTaskThree";
            this.labelTaskThree.Size = new System.Drawing.Size(120, 34);
            this.labelTaskThree.TabIndex = 4;
            this.labelTaskThree.Text = "Каталог товаров - Задание 3";
            // 
            // listBoxTaskThree
            // 
            this.listBoxTaskThree.FormattingEnabled = true;
            this.listBoxTaskThree.ItemHeight = 15;
            this.listBoxTaskThree.Location = new System.Drawing.Point(280, 52);
            this.listBoxTaskThree.Name = "listBoxTaskThree";
            this.listBoxTaskThree.Size = new System.Drawing.Size(120, 124);
            this.listBoxTaskThree.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(280, 182);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(280, 211);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(280, 240);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 23);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(280, 269);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(120, 23);
            this.buttonClean.TabIndex = 9;
            this.buttonClean.Text = "Очистить список";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(418, 311);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTaskThree);
            this.Controls.Add(this.labelTaskThree);
            this.Controls.Add(this.textBoxTaskTwo);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.textBoxTaskOne);
            this.Controls.Add(this.buttonTaskOne);
            this.Name = "Form1";
            this.Text = "HomeWork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonTaskOne;
        private TextBox textBoxTaskOne;
        private TextBox textBoxTaskTwo;
        private Button buttonTask2;
        private Label labelTaskThree;
        private ListBox listBoxTaskThree;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDel;
        private Button buttonClean;
    }
}