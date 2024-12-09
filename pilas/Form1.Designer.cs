namespace pilas
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
            label1 = new Label();
            txtNumero = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            lstPila = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 64);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(72, 93);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(165, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(72, 133);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(165, 39);
            btnPush.TabIndex = 2;
            btnPush.Text = "Agregar a la pila";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(72, 194);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(165, 39);
            btnPop.TabIndex = 3;
            btnPop.Text = "Eliminar de la pila";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // lstPila
            // 
            lstPila.Location = new Point(292, 53);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(163, 180);
            lstPila.TabIndex = 4;
            lstPila.UseCompatibleStateImageBehavior = false;
            lstPila.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 330);
            Controls.Add(lstPila);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnPush;
        private Button btnPop;
        private ListView lstPila;
    }
}
