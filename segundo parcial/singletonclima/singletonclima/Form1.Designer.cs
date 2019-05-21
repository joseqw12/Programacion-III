namespace singletonclima
{
    partial class miform
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntemperatura = new System.Windows.Forms.Button();
            this.btnmetodos = new System.Windows.Forms.Button();
            this.txttemperatura = new System.Windows.Forms.TextBox();
            this.lbtemperatura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbvalor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntemperatura
            // 
            this.btntemperatura.Location = new System.Drawing.Point(450, 82);
            this.btntemperatura.Name = "btntemperatura";
            this.btntemperatura.Size = new System.Drawing.Size(75, 23);
            this.btntemperatura.TabIndex = 0;
            this.btntemperatura.Text = "Temperatura";
            this.btntemperatura.UseVisualStyleBackColor = true;
            this.btntemperatura.Click += new System.EventHandler(this.btntemperatura_Click);
            // 
            // btnmetodos
            // 
            this.btnmetodos.Location = new System.Drawing.Point(450, 139);
            this.btnmetodos.Name = "btnmetodos";
            this.btnmetodos.Size = new System.Drawing.Size(75, 23);
            this.btnmetodos.TabIndex = 1;
            this.btnmetodos.Text = "Metodos";
            this.btnmetodos.UseVisualStyleBackColor = true;
            this.btnmetodos.Click += new System.EventHandler(this.btnmetodos_Click);
            // 
            // txttemperatura
            // 
            this.txttemperatura.Location = new System.Drawing.Point(234, 84);
            this.txttemperatura.Name = "txttemperatura";
            this.txttemperatura.Size = new System.Drawing.Size(100, 20);
            this.txttemperatura.TabIndex = 2;
            // 
            // lbtemperatura
            // 
            this.lbtemperatura.AutoSize = true;
            this.lbtemperatura.Location = new System.Drawing.Point(269, 139);
            this.lbtemperatura.Name = "lbtemperatura";
            this.lbtemperatura.Size = new System.Drawing.Size(10, 13);
            this.lbtemperatura.TabIndex = 3;
            this.lbtemperatura.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "valor";
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Location = new System.Drawing.Point(269, 173);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(10, 13);
            this.lbvalor.TabIndex = 5;
            this.lbvalor.Text = "-";
            // 
            // miform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtemperatura);
            this.Controls.Add(this.txttemperatura);
            this.Controls.Add(this.btnmetodos);
            this.Controls.Add(this.btntemperatura);
            this.Name = "miform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntemperatura;
        private System.Windows.Forms.Button btnmetodos;
        private System.Windows.Forms.TextBox txttemperatura;
        private System.Windows.Forms.Label lbtemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbvalor;
    }
}

