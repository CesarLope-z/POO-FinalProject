namespace POO_Catedra
{
    partial class Administrador
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            btnVolver = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(321, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(366, 265);
            dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(43, 202);
            button3.Name = "button3";
            button3.Size = new Size(136, 40);
            button3.TabIndex = 7;
            button3.Text = "Eliminar Usuario";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 142);
            button2.Name = "button2";
            button2.Size = new Size(136, 43);
            button2.TabIndex = 6;
            button2.Text = "Editar Usuario";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(43, 82);
            button1.Name = "button1";
            button1.Size = new Size(136, 43);
            button1.TabIndex = 5;
            button1.Text = "Crear Usuario";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 9;
            label1.Text = "Bienvenido, Administrador";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(43, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(136, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Cerrar Sesión";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // button4
            // 
            button4.Location = new Point(43, 298);
            button4.Name = "button4";
            button4.Size = new Size(136, 47);
            button4.TabIndex = 11;
            button4.Text = "Administrar Cita Medica";
            button4.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Administrador";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button btnVolver;
        private Button button4;
    }
}