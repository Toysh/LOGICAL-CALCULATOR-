namespace Калькулятор_логических_выражений
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.OR = new System.Windows.Forms.Button();
            this.NOT = new System.Windows.Forms.Button();
            this.IMPL = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.REV_IMPL = new System.Windows.Forms.Button();
            this.EQL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EQL);
            this.panel1.Controls.Add(this.REV_IMPL);
            this.panel1.Controls.Add(this.XOR);
            this.panel1.Controls.Add(this.IMPL);
            this.panel1.Controls.Add(this.NOT);
            this.panel1.Controls.Add(this.OR);
            this.panel1.Controls.Add(this.AND);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 406);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(374, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "≡";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(369, 26);
            this.textBox2.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(13, 13);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(104, 13);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 3;
            this.Load.Text = "Загрузить";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(186, 13);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 23);
            this.Clean.TabIndex = 4;
            this.Clean.Text = "Очистить";
            this.Clean.UseVisualStyleBackColor = true;
            // 
            // AND
            // 
            this.AND.Location = new System.Drawing.Point(44, 68);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(27, 27);
            this.AND.TabIndex = 3;
            this.AND.Text = "∧";
            this.AND.UseVisualStyleBackColor = true;
            // 
            // OR
            // 
            this.OR.Location = new System.Drawing.Point(77, 68);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(27, 27);
            this.OR.TabIndex = 4;
            this.OR.Text = "∨";
            this.OR.UseVisualStyleBackColor = true;
            // 
            // NOT
            // 
            this.NOT.Location = new System.Drawing.Point(11, 68);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(27, 27);
            this.NOT.TabIndex = 5;
            this.NOT.Text = "¬";
            this.NOT.UseVisualStyleBackColor = true;
            // 
            // IMPL
            // 
            this.IMPL.Location = new System.Drawing.Point(110, 68);
            this.IMPL.Name = "IMPL";
            this.IMPL.Size = new System.Drawing.Size(27, 27);
            this.IMPL.TabIndex = 6;
            this.IMPL.Text = "→";
            this.IMPL.UseVisualStyleBackColor = true;
            // 
            // XOR
            // 
            this.XOR.Location = new System.Drawing.Point(143, 68);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(27, 27);
            this.XOR.TabIndex = 7;
            this.XOR.Text = "⊕";
            this.XOR.UseVisualStyleBackColor = true;
            // 
            // REV_IMPL
            // 
            this.REV_IMPL.Location = new System.Drawing.Point(176, 68);
            this.REV_IMPL.Name = "REV_IMPL";
            this.REV_IMPL.Size = new System.Drawing.Size(27, 27);
            this.REV_IMPL.TabIndex = 8;
            this.REV_IMPL.Text = "←";
            this.REV_IMPL.UseVisualStyleBackColor = true;
            // 
            // EQL
            // 
            this.EQL.Location = new System.Drawing.Point(209, 68);
            this.EQL.Name = "EQL";
            this.EQL.Size = new System.Drawing.Size(27, 27);
            this.EQL.TabIndex = 9;
            this.EQL.Text = "≡";
            this.EQL.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Построить таблицу истинности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(362, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 24);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1-0";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(304, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 24);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "И-Л";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 286);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button  Load;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button IMPL;
        private System.Windows.Forms.Button NOT;
        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.Button AND;
        private System.Windows.Forms.Button EQL;
        private System.Windows.Forms.Button REV_IMPL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}

