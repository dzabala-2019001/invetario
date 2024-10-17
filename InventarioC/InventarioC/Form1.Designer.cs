namespace InventarioC
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
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            txtModelo = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtId = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(128, 176);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(191, 23);
            txtCantidad.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(128, 118);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(191, 23);
            txtModelo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 185);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 77);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 126);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 184);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "cantidad";
            // 
            // button1
            // 
            button1.Location = new Point(62, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 39);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 9;
            label4.Text = "id";
            // 
            // button2
            // 
            button2.Location = new Point(187, 231);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(128, 278);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "LIMPIAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtModelo);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCantidad;
        private TextBox txtModelo;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtId;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}
