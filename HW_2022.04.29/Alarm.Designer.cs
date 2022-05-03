namespace HW_2022._04._29
{
    partial class Alarm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsButtom = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Timer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.SettingsButtom, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.StartButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaskedTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Timer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 332);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SettingsButtom
            // 
            this.SettingsButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButtom.Location = new System.Drawing.Point(30, 284);
            this.SettingsButtom.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.SettingsButtom.Name = "SettingsButtom";
            this.SettingsButtom.Size = new System.Drawing.Size(221, 28);
            this.SettingsButtom.TabIndex = 0;
            this.SettingsButtom.Text = "Настройки";
            this.SettingsButtom.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Location = new System.Drawing.Point(30, 218);
            this.StopButton.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(221, 26);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Остановить будильник";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(30, 152);
            this.StartButton.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(221, 26);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Начать будильник";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MaskedTextBox
            // 
            this.MaskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedTextBox.Location = new System.Drawing.Point(70, 81);
            this.MaskedTextBox.Margin = new System.Windows.Forms.Padding(70, 15, 70, 15);
            this.MaskedTextBox.Mask = "00:00";
            this.MaskedTextBox.Name = "MaskedTextBox";
            this.MaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaskedTextBox.Size = new System.Drawing.Size(141, 39);
            this.MaskedTextBox.TabIndex = 3;
            this.MaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timer.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Timer.Location = new System.Drawing.Point(15, 10);
            this.Timer.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(251, 46);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "00:00:00";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Alarm";
            this.Text = "Будильник";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button SettingsButtom;
        private Button StopButton;
        private Button StartButton;
        private MaskedTextBox MaskedTextBox;
        private Label Timer;
    }
}