namespace Eco_Farm_ORM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select_pos_code = new System.Windows.Forms.Button();
            this.EntSQL = new System.Windows.Forms.Button();
            this.paramming = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObjQuery = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // select_pos_code
            // 
            this.select_pos_code.Location = new System.Drawing.Point(12, 11);
            this.select_pos_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_pos_code.Name = "select_pos_code";
            this.select_pos_code.Size = new System.Drawing.Size(139, 74);
            this.select_pos_code.TabIndex = 12;
            this.select_pos_code.Text = "Select employees by criteria of position";
            this.select_pos_code.UseVisualStyleBackColor = true;
            this.select_pos_code.Click += new System.EventHandler(this.select_pos_code_Click);
            // 
            // EntSQL
            // 
            this.EntSQL.Location = new System.Drawing.Point(166, 12);
            this.EntSQL.Name = "EntSQL";
            this.EntSQL.Size = new System.Drawing.Size(122, 73);
            this.EntSQL.TabIndex = 13;
            this.EntSQL.Text = "Entity SQL";
            this.EntSQL.UseVisualStyleBackColor = true;
            this.EntSQL.Click += new System.EventHandler(this.EntSQL_Click);
            // 
            // paramming
            // 
            this.paramming.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paramming.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramming.Location = new System.Drawing.Point(6, 21);
            this.paramming.Multiline = true;
            this.paramming.Name = "paramming";
            this.paramming.Size = new System.Drawing.Size(149, 46);
            this.paramming.TabIndex = 2;
            this.paramming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paramming);
            this.groupBox1.Location = new System.Drawing.Point(294, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 73);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите параметр";
            // 
            // ObjQuery
            // 
            this.ObjQuery.Location = new System.Drawing.Point(476, 33);
            this.ObjQuery.Name = "ObjQuery";
            this.ObjQuery.Size = new System.Drawing.Size(88, 42);
            this.ObjQuery.TabIndex = 15;
            this.ObjQuery.Text = "Object Query";
            this.ObjQuery.UseVisualStyleBackColor = true;
            this.ObjQuery.Click += new System.EventHandler(this.ObjQuery_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Начальник отдела закупок",
            "Начальник отдела продаж",
            "Охранник",
            "Бухгалтер",
            "Доставщик",
            "Keeper"});
            this.comboBox1.Location = new System.Drawing.Point(582, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ObjQuery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EntSQL);
            this.Controls.Add(this.select_pos_code);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Eco Farm ORM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button select_pos_code;
        private System.Windows.Forms.Button EntSQL;
        private System.Windows.Forms.TextBox paramming;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ObjQuery;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

