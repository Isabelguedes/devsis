namespace WindowsFormsApplication1
{
    partial class mes
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
            this.txtMes = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.textMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMes
            // 
            this.txtMes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMes.FormattingEnabled = true;
            this.txtMes.Items.AddRange(new object[] {
            "Selecionar",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.txtMes.Location = new System.Drawing.Point(184, 105);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(203, 21);
            this.txtMes.TabIndex = 0;
            this.txtMes.SelectedIndexChanged += new System.EventHandler(this.cbMeses_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label.Location = new System.Drawing.Point(55, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 18);
            this.label.TabIndex = 1;
            this.label.Text = "Escolha um mês";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMes
            // 
            this.textMes.AutoSize = true;
            this.textMes.Location = new System.Drawing.Point(103, 173);
            this.textMes.Name = "textMes";
            this.textMes.Size = new System.Drawing.Size(0, 13);
            this.textMes.TabIndex = 2;
            // 
            // mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(651, 506);
            this.Controls.Add(this.textMes);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtMes);
            this.Name = "mes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMes;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label textMes;
    }
}

