namespace PW_2022._05._09
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
            this.labelTaskOne = new System.Windows.Forms.Label();
            this.textBoxTextRedactor = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTaskTwo = new System.Windows.Forms.Label();
            this.textBoxTaskTwo = new System.Windows.Forms.TextBox();
            this.buttonLoadT2 = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTaskOne
            // 
            this.labelTaskOne.AutoSize = true;
            this.labelTaskOne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaskOne.Location = new System.Drawing.Point(12, 9);
            this.labelTaskOne.Name = "labelTaskOne";
            this.labelTaskOne.Size = new System.Drawing.Size(130, 17);
            this.labelTaskOne.TabIndex = 0;
            this.labelTaskOne.Text = "Текстовый редактор";
            // 
            // textBoxTextRedactor
            // 
            this.textBoxTextRedactor.Location = new System.Drawing.Point(12, 29);
            this.textBoxTextRedactor.Multiline = true;
            this.textBoxTextRedactor.Name = "textBoxTextRedactor";
            this.textBoxTextRedactor.Size = new System.Drawing.Size(267, 179);
            this.textBoxTextRedactor.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(12, 214);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(130, 29);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(148, 214);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 29);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTaskTwo
            // 
            this.labelTaskTwo.AutoSize = true;
            this.labelTaskTwo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaskTwo.Location = new System.Drawing.Point(384, 9);
            this.labelTaskTwo.Name = "labelTaskTwo";
            this.labelTaskTwo.Size = new System.Drawing.Size(202, 17);
            this.labelTaskTwo.TabIndex = 4;
            this.labelTaskTwo.Text = "Текстовый редактор (Задание 2)";
            // 
            // textBoxTaskTwo
            // 
            this.textBoxTaskTwo.Location = new System.Drawing.Point(384, 29);
            this.textBoxTaskTwo.Multiline = true;
            this.textBoxTaskTwo.Name = "textBoxTaskTwo";
            this.textBoxTaskTwo.ReadOnly = true;
            this.textBoxTaskTwo.Size = new System.Drawing.Size(267, 179);
            this.textBoxTaskTwo.TabIndex = 5;
            // 
            // buttonLoadT2
            // 
            this.buttonLoadT2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadT2.Location = new System.Drawing.Point(384, 214);
            this.buttonLoadT2.Name = "buttonLoadT2";
            this.buttonLoadT2.Size = new System.Drawing.Size(130, 29);
            this.buttonLoadT2.TabIndex = 6;
            this.buttonLoadT2.Text = "Загрузить";
            this.buttonLoadT2.UseVisualStyleBackColor = true;
            this.buttonLoadT2.Click += new System.EventHandler(this.buttonLoadT2_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(521, 214);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 29);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonLoadT2);
            this.Controls.Add(this.textBoxTaskTwo);
            this.Controls.Add(this.labelTaskTwo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxTextRedactor);
            this.Controls.Add(this.labelTaskOne);
            this.Name = "Form1";
            this.Text = "Practical Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTaskOne;
        private TextBox textBoxTextRedactor;
        private Button buttonLoad;
        private Button buttonSave;
        private Label labelTaskTwo;
        private TextBox textBoxTaskTwo;
        private Button buttonLoadT2;
        private Button buttonEdit;
    }
}