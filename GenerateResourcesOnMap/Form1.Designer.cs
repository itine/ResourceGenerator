﻿namespace GenerateResourcesOnMap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 37);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Показать";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.Location = new System.Drawing.Point(100, 7);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 729);
            this.dataGridView1.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01_ атака+1 палатки.jpg");
            this.imageList1.Images.SetKeyName(1, "02_защита+1 башня.jpg");
            this.imageList1.Images.SetKeyName(2, "03_spell power +1 магическая статуя.jpg");
            this.imageList1.Images.SetKeyName(3, "04_knowledge+1 статуя знания.jpg");
            this.imageList1.Images.SetKeyName(4, "09_останки.jpg");
            this.imageList1.Images.SetKeyName(5, "15_обелиск портала.jpg");
            this.imageList1.Images.SetKeyName(6, "17_ящик пандоры.jpg");
            this.imageList1.Images.SetKeyName(7, "18_хранилище циклопов.jpg");
            this.imageList1.Images.SetKeyName(8, "19_хранилище големов.jpg");
            this.imageList1.Images.SetKeyName(9, "20_хранилище облачных странников.jpg");
            this.imageList1.Images.SetKeyName(10, "21_хранилище воров.jpg");
            this.imageList1.Images.SetKeyName(11, "22_хранилище клириков.jpg");
            this.imageList1.Images.SetKeyName(12, "23_кладбище вампиров.jpg");
            this.imageList1.Images.SetKeyName(13, "05_обелиск опыта.jpg");
            this.imageList1.Images.SetKeyName(14, "06_фонтан удачи 2.jpg");
            this.imageList1.Images.SetKeyName(15, "07_статуя морали 1.jpg");
            this.imageList1.Images.SetKeyName(16, "13_танцующий мальчик.jpg");
            this.imageList1.Images.SetKeyName(17, "14_конюшня.jpg");
            this.imageList1.Images.SetKeyName(18, "08_колодец маны.jpg");
            this.imageList1.Images.SetKeyName(19, "10_водяная мельница.jpg");
            this.imageList1.Images.SetKeyName(20, "11_ветряная мельница.jpg");
            this.imageList1.Images.SetKeyName(21, "12_рынок обмена ресурсов.jpg");
            this.imageList1.Images.SetKeyName(22, "16_табличка с надписью.jpg");
            this.imageList1.Images.SetKeyName(23, "123.png");
            this.imageList1.Images.SetKeyName(24, "01_елка.jpg");
            this.imageList1.Images.SetKeyName(25, "02_березка.jpg");
            this.imageList1.Images.SetKeyName(26, "03_куст.jpg");
            this.imageList1.Images.SetKeyName(27, "04_кактус.jpg");
            this.imageList1.Images.SetKeyName(28, "05_норка.jpg");
            this.imageList1.Images.SetKeyName(29, "06_пенек.jpg");
            this.imageList1.Images.SetKeyName(30, "07_грибы шампиньоны.jpg");
            this.imageList1.Images.SetKeyName(31, "08_глаз.jpg");
            this.imageList1.Images.SetKeyName(32, "09_портал.jpg");
            this.imageList1.Images.SetKeyName(33, "10_камни декорация.jpg");
            this.imageList1.Images.SetKeyName(34, "01_золото.png");
            this.imageList1.Images.SetKeyName(35, "02_сундук.png");
            this.imageList1.Images.SetKeyName(36, "03_костерок.png");
            this.imageList1.Images.SetKeyName(37, "04_дерево.png");
            this.imageList1.Images.SetKeyName(38, "05_камни.png");
            this.imageList1.Images.SetKeyName(39, "06_ртуть.png");
            this.imageList1.Images.SetKeyName(40, "07_сера.png");
            this.imageList1.Images.SetKeyName(41, "08_кристаллы.png");
            this.imageList1.Images.SetKeyName(42, "09_самоцветы.png");
            this.imageList1.Images.SetKeyName(43, "10_банка жизни.png");
            this.imageList1.Images.SetKeyName(44, "11_банка маны.png");
            this.imageList1.Images.SetKeyName(45, "01 шипастая дубина.png");
            this.imageList1.Images.SetKeyName(46, "02 тесак мясника.png");
            this.imageList1.Images.SetKeyName(47, "03 меч рыцаря.png");
            this.imageList1.Images.SetKeyName(48, "04 праща хоббита.png");
            this.imageList1.Images.SetKeyName(49, "05 клинок ярости.png");
            this.imageList1.Images.SetKeyName(50, "06 топор войны.png");
            this.imageList1.Images.SetKeyName(51, "07 эльфийский лук.png");
            this.imageList1.Images.SetKeyName(52, "08 цеп гнолла.png");
            this.imageList1.Images.SetKeyName(53, "09 палица безумца.png");
            this.imageList1.Images.SetKeyName(54, "10 деревянный посох.png");
            this.imageList1.Images.SetKeyName(55, "01 деревянный щит.png");
            this.imageList1.Images.SetKeyName(56, "02 ржавый щит.png");
            this.imageList1.Images.SetKeyName(57, "03 большой щит.png");
            this.imageList1.Images.SetKeyName(58, "04 круглый щит.png");
            this.imageList1.Images.SetKeyName(59, "05 полуторный щит.png");
            this.imageList1.Images.SetKeyName(60, "06 башня.png");
            this.imageList1.Images.SetKeyName(61, "07 щит дварва.png");
            this.imageList1.Images.SetKeyName(62, "08 туларенский щит.png");
            this.imageList1.Images.SetKeyName(63, "09 щит безумца.png");
            this.imageList1.Images.SetKeyName(64, "10 тяжелый щит.png");
            this.imageList1.Images.SetKeyName(65, "1_rzhavy_shlem.png");
            this.imageList1.Images.SetKeyName(66, "2_rogaty_shlem.png");
            this.imageList1.Images.SetKeyName(67, "4_kolpak_maga.png");
            this.imageList1.Images.SetKeyName(68, "01_дубина гоблина.png");
            this.imageList1.Images.SetKeyName(69, "Bronze helmet_by TW.png");
            this.imageList1.Images.SetKeyName(70, "Дамасский меч.png");
            this.imageList1.Images.SetKeyName(71, "домик-фей.png");
            this.imageList1.Images.SetKeyName(72, "01_копейщик.png");
            this.imageList1.Images.SetKeyName(73, "02_арбалетчик.png");
            this.imageList1.Images.SetKeyName(74, "03_несущий свет.png");
            this.imageList1.Images.SetKeyName(75, "04_клирик.png");
            this.imageList1.Images.SetKeyName(76, "05_инквизитор.png");
            this.imageList1.Images.SetKeyName(77, "06_кавалерист.png");
            this.imageList1.Images.SetKeyName(78, "07_королевский палач.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = " ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Статистика";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(142, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 657);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Статистика";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 64);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(115, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 64);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Resource generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

