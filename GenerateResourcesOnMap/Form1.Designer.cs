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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Location = new System.Drawing.Point(100, 7);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
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
            this.imageList1.Images.SetKeyName(72, "07_королевский палач.png");
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Resource generator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

