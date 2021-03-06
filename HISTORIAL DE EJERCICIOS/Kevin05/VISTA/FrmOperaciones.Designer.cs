
namespace Kevin01.VISTA
{
    partial class FrmOperaciones
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
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.Silver;
            this.BtnSuma.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnSuma.Location = new System.Drawing.Point(529, 90);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(113, 47);
            this.BtnSuma.TabIndex = 0;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.BackColor = System.Drawing.Color.Silver;
            this.BtnResta.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnResta.Location = new System.Drawing.Point(529, 166);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(113, 46);
            this.BtnResta.TabIndex = 1;
            this.BtnResta.Text = "Resta";
            this.BtnResta.UseVisualStyleBackColor = false;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // txtDato1
            // 
            this.txtDato1.BackColor = System.Drawing.SystemColors.Window;
            this.txtDato1.Location = new System.Drawing.Point(128, 117);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(219, 20);
            this.txtDato1.TabIndex = 2;
            // 
            // txtDato2
            // 
            this.txtDato2.BackColor = System.Drawing.SystemColors.Window;
            this.txtDato2.Location = new System.Drawing.Point(128, 231);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(218, 20);
            this.txtDato2.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(128, 332);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(219, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(128, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa un Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(128, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingresa un Segundo Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(128, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.BackColor = System.Drawing.Color.Silver;
            this.BtnMultiplicar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnMultiplicar.Location = new System.Drawing.Point(529, 231);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(113, 46);
            this.BtnMultiplicar.TabIndex = 8;
            this.BtnMultiplicar.Text = "Multi";
            this.BtnMultiplicar.UseVisualStyleBackColor = false;
            this.BtnMultiplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.Silver;
            this.BtnDiv.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnDiv.Location = new System.Drawing.Point(529, 306);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(113, 46);
            this.BtnDiv.TabIndex = 9;
            this.BtnDiv.Text = "Divi";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Name = "FrmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOperaciones";
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnResta;
        public System.Windows.Forms.Button BtnSuma;
        public System.Windows.Forms.Button BtnMultiplicar;
        public System.Windows.Forms.Button BtnDiv;
    }
}