namespace POO_Catedra
{
    partial class Inicio
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
            label2 = new Label();
            button1 = new Button();
            btnVolverP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 76);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Citas Registradas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 241);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 29);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 4;
            label2.Text = "Bienvenido, Paciente";
            // 
            // button1
            // 
            button1.Location = new Point(81, 106);
            button1.Name = "button1";
            button1.Size = new Size(175, 47);
            button1.TabIndex = 5;
            button1.Text = "Crear Cita Medica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVolverP
            // 
            btnVolverP.Location = new Point(81, 315);
            btnVolverP.Name = "btnVolverP";
            btnVolverP.Size = new Size(175, 32);
            btnVolverP.TabIndex = 6;
            btnVolverP.Text = "Cerrar Sesión";
            btnVolverP.UseVisualStyleBackColor = true;
            btnVolverP.Click += btnVolverP_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 359);
            Controls.Add(btnVolverP);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private Button btnVolverP;
    }
}