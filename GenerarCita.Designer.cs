namespace POO_Catedra
{
    partial class GenerarCita
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
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 135);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Medico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "Especialidad";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(29, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 23);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 11;
            label1.Text = "Deseas Agendar una cita?";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(29, 217);
            button1.Name = "button1";
            button1.Size = new Size(240, 36);
            button1.TabIndex = 13;
            button1.Text = "Consulta aquí la disponibilidad del medico";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 58);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 14;
            label2.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 135);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 15;
            label5.Text = "Hora:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(350, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(350, 153);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(229, 23);
            dateTimePicker2.TabIndex = 17;
            dateTimePicker2.Value = new DateTime(2025, 9, 12, 22, 22, 0, 0);
            // 
            // button2
            // 
            button2.Location = new Point(350, 311);
            button2.Name = "button2";
            button2.Size = new Size(229, 65);
            button2.TabIndex = 18;
            button2.Text = "Crear cita";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 228);
            label6.Name = "label6";
            label6.Size = new Size(233, 15);
            label6.TabIndex = 19;
            label6.Text = "En caso de cualquier error se mostrará aqui";
            // 
            // button3
            // 
            button3.Location = new Point(350, 395);
            button3.Name = "button3";
            button3.Size = new Size(229, 28);
            button3.TabIndex = 20;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GenerarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 447);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "GenerarCita";
            Text = "GenerarCita";
            Load += GenerarCita_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Label label6;
        private Button button3;
    }
}