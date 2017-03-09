namespace Condicional
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso tecnico informatica";
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo.ForeColor = System.Drawing.Color.Blue;
            this.subtitulo.Location = new System.Drawing.Point(103, 42);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(187, 16);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Desevolvimento de Sistema 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe sua idade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(133, 109);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(126, 20);
            this.textIdade.TabIndex = 3;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(184, 144);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 4;
            this.bt.Text = "Infome";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 568);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subtitulo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.Button bt;
    }
}

