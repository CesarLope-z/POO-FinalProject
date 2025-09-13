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
            button3.Location = new Point(43, 269);
            button3.Name = "button3";
            button3.Size = new Size(136, 40);
            button3.TabIndex = 7;
            button3.Text = "Eliminar Usuario";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 196);
            button2.Name = "button2";
            button2.Size = new Size(136, 43);
            button2.TabIndex = 6;
            button2.Text = "Editar Usuario";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(43, 129);
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
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}