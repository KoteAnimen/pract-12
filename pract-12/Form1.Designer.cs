namespace pract_12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.numberTask = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentData = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuAnswer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetAnswerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GetAnswerPS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.perimeter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuInputA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Input567 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.sideSquare = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuAnswerN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetAnswerNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.GetAnswer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.TextBox();
            this.tens = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contextMenuInputN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Input435 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuAnswer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuInputA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideSquare)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuAnswerN.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuInputN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.ToolTipText = "Тут содержится кнопка выход";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUs});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.ToolTipText = "Информация о программе";
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(151, 22);
            this.AboutUs.Text = "О Программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberTask,
            this.currentData,
            this.currentTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(388, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // numberTask
            // 
            this.numberTask.Name = "numberTask";
            this.numberTask.Size = new System.Drawing.Size(85, 17);
            this.numberTask.Text = "Номер задачи";
            // 
            // currentData
            // 
            this.currentData.Name = "currentData";
            this.currentData.Size = new System.Drawing.Size(32, 17);
            this.currentData.Text = "Дата";
            // 
            // currentTime
            // 
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(42, 17);
            this.currentTime.Text = "Время";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 233);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.ChangeNumberTask);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Периметр и площадь квадрата";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.ContextMenuStrip = this.contextMenuAnswer;
            this.groupBox2.Controls.Add(this.GetAnswerPS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.area);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.perimeter);
            this.groupBox2.Location = new System.Drawing.Point(6, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // contextMenuAnswer
            // 
            this.contextMenuAnswer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetAnswerMenu});
            this.contextMenuAnswer.Name = "contextMenuAnswer";
            this.contextMenuAnswer.Size = new System.Drawing.Size(136, 26);
            // 
            // GetAnswerMenu
            // 
            this.GetAnswerMenu.Name = "GetAnswerMenu";
            this.GetAnswerMenu.Size = new System.Drawing.Size(135, 22);
            this.GetAnswerMenu.Text = "Рассчитать";
            this.GetAnswerMenu.Click += new System.EventHandler(this.GetAnswerMenu_Click);
            // 
            // GetAnswerPS
            // 
            this.GetAnswerPS.Location = new System.Drawing.Point(104, 73);
            this.GetAnswerPS.Name = "GetAnswerPS";
            this.GetAnswerPS.Size = new System.Drawing.Size(143, 23);
            this.GetAnswerPS.TabIndex = 4;
            this.GetAnswerPS.Text = "Получить ответ";
            this.GetAnswerPS.UseVisualStyleBackColor = true;
            this.GetAnswerPS.Click += new System.EventHandler(this.GetAnswerPS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Площадь";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(247, 42);
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Size = new System.Drawing.Size(100, 20);
            this.area.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Периметр";
            // 
            // perimeter
            // 
            this.perimeter.Location = new System.Drawing.Point(6, 42);
            this.perimeter.Name = "perimeter";
            this.perimeter.ReadOnly = true;
            this.perimeter.Size = new System.Drawing.Size(100, 20);
            this.perimeter.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuInputA;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sideSquare);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // contextMenuInputA
            // 
            this.contextMenuInputA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenuInputA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Input567});
            this.contextMenuInputA.Name = "contextMenuStrip1";
            this.contextMenuInputA.Size = new System.Drawing.Size(133, 26);
            this.contextMenuInputA.Text = "Ввод шаблонов чисел";
            // 
            // Input567
            // 
            this.Input567.Name = "Input567";
            this.Input567.Size = new System.Drawing.Size(132, 22);
            this.Input567.Text = "Ввести 567";
            this.Input567.Click += new System.EventHandler(this.Input567_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина стороны квадрата";
            // 
            // sideSquare
            // 
            this.sideSquare.Location = new System.Drawing.Point(6, 50);
            this.sideSquare.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sideSquare.Name = "sideSquare";
            this.sideSquare.Size = new System.Drawing.Size(157, 20);
            this.sideSquare.TabIndex = 0;
            this.sideSquare.ValueChanged += new System.EventHandler(this.ClearAnswerPS);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Десятки и единицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.ContextMenuStrip = this.contextMenuAnswerN;
            this.groupBox4.Controls.Add(this.GetAnswer);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.terms);
            this.groupBox4.Controls.Add(this.tens);
            this.groupBox4.Location = new System.Drawing.Point(6, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 104);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
            // 
            // contextMenuAnswerN
            // 
            this.contextMenuAnswerN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetAnswerNumber});
            this.contextMenuAnswerN.Name = "contextMenuAnswerN";
            this.contextMenuAnswerN.Size = new System.Drawing.Size(216, 26);
            // 
            // GetAnswerNumber
            // 
            this.GetAnswerNumber.Name = "GetAnswerNumber";
            this.GetAnswerNumber.Size = new System.Drawing.Size(215, 22);
            this.GetAnswerNumber.Text = "Найти десятки и единицы";
            this.GetAnswerNumber.Click += new System.EventHandler(this.GetAnswerNumber_Click);
            // 
            // GetAnswer
            // 
            this.GetAnswer.Location = new System.Drawing.Point(104, 73);
            this.GetAnswer.Name = "GetAnswer";
            this.GetAnswer.Size = new System.Drawing.Size(143, 23);
            this.GetAnswer.TabIndex = 4;
            this.GetAnswer.Text = "Получить ответ";
            this.GetAnswer.UseVisualStyleBackColor = true;
            this.GetAnswer.Click += new System.EventHandler(this.GetAnswer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Единицы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Десятки";
            // 
            // terms
            // 
            this.terms.Location = new System.Drawing.Point(247, 42);
            this.terms.Name = "terms";
            this.terms.ReadOnly = true;
            this.terms.Size = new System.Drawing.Size(100, 20);
            this.terms.TabIndex = 1;
            // 
            // tens
            // 
            this.tens.Location = new System.Drawing.Point(6, 42);
            this.tens.Name = "tens";
            this.tens.ReadOnly = true;
            this.tens.Size = new System.Drawing.Size(100, 20);
            this.tens.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.ContextMenuStrip = this.contextMenuInputN;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.number);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходные данные";
            // 
            // contextMenuInputN
            // 
            this.contextMenuInputN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Input435});
            this.contextMenuInputN.Name = "contextMenuInputN";
            this.contextMenuInputN.Size = new System.Drawing.Size(133, 26);
            // 
            // Input435
            // 
            this.Input435.Name = "Input435";
            this.Input435.Size = new System.Drawing.Size(132, 22);
            this.Input435.Text = "Ввести 435";
            this.Input435.Click += new System.EventHandler(this.Input435_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Исходное число";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(6, 50);
            this.number.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(157, 20);
            this.number.TabIndex = 0;
            this.number.ValueChanged += new System.EventHandler(this.ClearAnswerN);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.UpdateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 288);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №12";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuAnswer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuInputA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sideSquare)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuAnswerN.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuInputN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel numberTask;
        private System.Windows.Forms.ToolStripStatusLabel currentData;
        private System.Windows.Forms.ToolStripStatusLabel currentTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox perimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sideSquare;
        private System.Windows.Forms.TextBox terms;
        private System.Windows.Forms.TextBox tens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetAnswerPS;
        private System.Windows.Forms.Button GetAnswer;
        private System.Windows.Forms.ContextMenuStrip contextMenuInputA;
        private System.Windows.Forms.ToolStripMenuItem Input567;
        private System.Windows.Forms.ContextMenuStrip contextMenuAnswer;
        private System.Windows.Forms.ToolStripMenuItem GetAnswerMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuInputN;
        private System.Windows.Forms.ToolStripMenuItem Input435;
        private System.Windows.Forms.ContextMenuStrip contextMenuAnswerN;
        private System.Windows.Forms.ToolStripMenuItem GetAnswerNumber;
        private System.Windows.Forms.Timer timer1;
    }
}

