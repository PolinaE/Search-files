namespace searchFiles
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.choosePath_Button = new System.Windows.Forms.Button();
            this.startSearch_Button = new System.Windows.Forms.Button();
            this.pause_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_Label = new System.Windows.Forms.Label();
            this.fileName_Label = new System.Windows.Forms.Label();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mask_textBox = new System.Windows.Forms.TextBox();
            this.contains_textBox = new System.Windows.Forms.TextBox();
            this.countFiles_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ftLocation = new System.Windows.Forms.ListBox();
            this.continue_Button = new System.Windows.Forms.Button();
            this.break_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // choosePath_Button
            // 
            this.choosePath_Button.Location = new System.Drawing.Point(774, 25);
            this.choosePath_Button.Name = "choosePath_Button";
            this.choosePath_Button.Size = new System.Drawing.Size(78, 23);
            this.choosePath_Button.TabIndex = 0;
            this.choosePath_Button.Text = "Путь";
            this.choosePath_Button.UseVisualStyleBackColor = true;
            this.choosePath_Button.Click += new System.EventHandler(this.choosePath_Button_Click);
            // 
            // startSearch_Button
            // 
            this.startSearch_Button.Location = new System.Drawing.Point(31, 170);
            this.startSearch_Button.Name = "startSearch_Button";
            this.startSearch_Button.Size = new System.Drawing.Size(78, 23);
            this.startSearch_Button.TabIndex = 1;
            this.startSearch_Button.Text = "Начать";
            this.startSearch_Button.UseVisualStyleBackColor = true;
            this.startSearch_Button.Click += new System.EventHandler(this.startSearch_Button_Click);
            // 
            // pause_Button
            // 
            this.pause_Button.Location = new System.Drawing.Point(31, 199);
            this.pause_Button.Name = "pause_Button";
            this.pause_Button.Size = new System.Drawing.Size(78, 23);
            this.pause_Button.TabIndex = 2;
            this.pause_Button.Text = "Пауза";
            this.pause_Button.UseVisualStyleBackColor = true;
            this.pause_Button.Click += new System.EventHandler(this.pause_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_Label
            // 
            this.time_Label.AutoSize = true;
            this.time_Label.Location = new System.Drawing.Point(218, 90);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(0, 13);
            this.time_Label.TabIndex = 6;
            // 
            // fileName_Label
            // 
            this.fileName_Label.AutoSize = true;
            this.fileName_Label.Location = new System.Drawing.Point(218, 30);
            this.fileName_Label.Name = "fileName_Label";
            this.fileName_Label.Size = new System.Drawing.Size(0, 13);
            this.fileName_Label.TabIndex = 8;
            // 
            // path_textBox
            // 
            this.path_textBox.Location = new System.Drawing.Point(206, 27);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(535, 20);
            this.path_textBox.TabIndex = 9;
            // 
            // mask_textBox
            // 
            this.mask_textBox.Location = new System.Drawing.Point(206, 57);
            this.mask_textBox.Name = "mask_textBox";
            this.mask_textBox.Size = new System.Drawing.Size(535, 20);
            this.mask_textBox.TabIndex = 10;
            // 
            // contains_textBox
            // 
            this.contains_textBox.Location = new System.Drawing.Point(206, 87);
            this.contains_textBox.Name = "contains_textBox";
            this.contains_textBox.Size = new System.Drawing.Size(535, 20);
            this.contains_textBox.TabIndex = 11;
            // 
            // countFiles_Label
            // 
            this.countFiles_Label.AutoSize = true;
            this.countFiles_Label.Location = new System.Drawing.Point(218, 60);
            this.countFiles_Label.Name = "countFiles_Label";
            this.countFiles_Label.Size = new System.Drawing.Size(0, 13);
            this.countFiles_Label.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Шаблон имени файлов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Текст, содержащийся в файле";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Стартовая директория";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contains_textBox);
            this.groupBox1.Controls.Add(this.path_textBox);
            this.groupBox1.Controls.Add(this.mask_textBox);
            this.groupBox1.Controls.Add(this.choosePath_Button);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 122);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите критерии поиска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Обрабатывается файл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Количество обработанных файлов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Прошедшее время:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.time_Label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fileName_Label);
            this.groupBox2.Controls.Add(this.countFiles_Label);
            this.groupBox2.Location = new System.Drawing.Point(31, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 147);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о поиске";
            // 
            // ftLocation
            // 
            this.ftLocation.FormattingEnabled = true;
            this.ftLocation.Location = new System.Drawing.Point(446, 170);
            this.ftLocation.Name = "ftLocation";
            this.ftLocation.Size = new System.Drawing.Size(452, 251);
            this.ftLocation.TabIndex = 22;
            this.ftLocation.Visible = false;
            // 
            // continue_Button
            // 
            this.continue_Button.Location = new System.Drawing.Point(154, 199);
            this.continue_Button.Name = "continue_Button";
            this.continue_Button.Size = new System.Drawing.Size(78, 23);
            this.continue_Button.TabIndex = 23;
            this.continue_Button.Text = "Продолжить";
            this.continue_Button.UseVisualStyleBackColor = true;
            this.continue_Button.Click += new System.EventHandler(this.continue_Button_Click);
            // 
            // break_Button
            // 
            this.break_Button.Location = new System.Drawing.Point(31, 228);
            this.break_Button.Name = "break_Button";
            this.break_Button.Size = new System.Drawing.Size(78, 23);
            this.break_Button.TabIndex = 24;
            this.break_Button.Text = "Прервать";
            this.break_Button.UseVisualStyleBackColor = true;
            this.break_Button.Click += new System.EventHandler(this.break_Button_Click);
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(154, 228);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(78, 23);
            this.close_Button.TabIndex = 25;
            this.close_Button.Text = "Закрыть";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 435);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.break_Button);
            this.Controls.Add(this.continue_Button);
            this.Controls.Add(this.ftLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pause_Button);
            this.Controls.Add(this.startSearch_Button);
            this.Name = "Form1";
            this.Text = "Поиск файлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choosePath_Button;
        private System.Windows.Forms.Button startSearch_Button;
        private System.Windows.Forms.Button pause_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.Label fileName_Label;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox mask_textBox;
        private System.Windows.Forms.TextBox contains_textBox;
        private System.Windows.Forms.Label countFiles_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ftLocation;
        private System.Windows.Forms.Button continue_Button;
        private System.Windows.Forms.Button break_Button;
        private System.Windows.Forms.Button close_Button;
    }
}

