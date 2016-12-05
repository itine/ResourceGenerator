namespace GenerateResourcesOnMap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(19, 185);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(137, 37);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 640);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

