namespace RegistroHabitantes
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            cmbEstadoCivil = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 12);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 245);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "email";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(227, 67);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(204, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 69);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // button1
            // 
            button1.Location = new Point(97, 350);
            button1.Name = "button1";
            button1.Size = new Size(124, 33);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(97, 406);
            button2.Name = "button2";
            button2.Size = new Size(124, 33);
            button2.TabIndex = 7;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(97, 462);
            button3.Name = "button3";
            button3.Size = new Size(124, 33);
            button3.TabIndex = 8;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 130);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 10;
            label4.Text = "Estado Civil";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(227, 127);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(204, 33);
            cmbEstadoCivil.TabIndex = 11;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "";
            dtpFechaNacimiento.Location = new Point(227, 183);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(204, 31);
            dtpFechaNacimiento.TabIndex = 12;
            dtpFechaNacimiento.Value = new DateTime(2025, 10, 23, 0, 25, 9, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 183);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 13;
            label5.Text = "Fecha de Nacimiento";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(553, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(620, 260);
            dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 559);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cmbEstadoCivil);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private ComboBox cmbEstadoCivil;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private DataGridView dataGridView1;
    }
}
