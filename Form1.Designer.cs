namespace Practica_14
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
            label2 = new Label();
            calificacion = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(315, 26);
            label1.TabIndex = 0;
            label1.Text = "Favor de ingresar su calificacion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 1;
            label2.Text = "Calificación";
            // 
            // calificacion
            // 
            calificacion.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            calificacion.Location = new Point(181, 95);
            calificacion.Name = "calificacion";
            calificacion.Size = new Size(127, 33);
            calificacion.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(98, 183);
            button1.Name = "button1";
            button1.Size = new Size(128, 38);
            button1.TabIndex = 3;
            button1.Text = "Desición";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 238);
            Controls.Add(button1);
            Controls.Add(calificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Practica 14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox calificacion;
        private Button button1;
    }
}