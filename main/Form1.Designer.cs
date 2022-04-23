namespace main
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
            this.button1 = new System.Windows.Forms.Button();
            this.Rows = new System.Windows.Forms.TextBox();
            this.Columns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.Before = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(300, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать массив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(178, 26);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(100, 22);
            this.Rows.TabIndex = 1;
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(178, 66);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(100, 22);
            this.Columns.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество строк :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество столбцов :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Диапозон случайных значений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "от :";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(649, 66);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(53, 22);
            this.From.TabIndex = 7;
            // 
            // Before
            // 
            this.Before.Location = new System.Drawing.Point(756, 66);
            this.Before.Name = "Before";
            this.Before.Size = new System.Drawing.Size(55, 22);
            this.Before.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "до :";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(19, 137);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(683, 302);
            this.Table.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Обнулить главную диогональ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(765, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "Обнулить побочную диогональ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(724, 280);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(238, 159);
            this.TextBox.TabIndex = 13;
            this.TextBox.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(987, 537);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Before);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Rows;
        private System.Windows.Forms.TextBox Columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox Before;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}

