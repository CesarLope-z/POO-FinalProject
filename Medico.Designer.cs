﻿namespace POO_Catedra
{
    partial class Medico
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnVolverM = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 46);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Citas medicas";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(470, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(470, 288);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(240, 150);
            dataGridView3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 22);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Bienvenido, Médico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 260);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 6;
            label4.Text = "Horarios de atención";
            // 
            // button1
            // 
            button1.Location = new Point(126, 197);
            button1.Name = "button1";
            button1.Size = new Size(211, 56);
            button1.TabIndex = 7;
            button1.Text = "Buscar Expediente medico de persona";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(126, 104);
            button2.Name = "button2";
            button2.Size = new Size(211, 56);
            button2.TabIndex = 8;
            button2.Text = "Administrar cita";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnVolverM
            // 
            btnVolverM.Location = new Point(126, 406);
            btnVolverM.Name = "btnVolverM";
            btnVolverM.Size = new Size(211, 32);
            btnVolverM.TabIndex = 9;
            btnVolverM.Text = "Cerrar Sesión";
            btnVolverM.UseVisualStyleBackColor = true;
            btnVolverM.Click += btnVolverM_Click;
            // 
            // Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverM);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Medico";
            Text = "Medico";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private Label label2;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button btnVolverM;
    }
}