namespace clientechat
{
    partial class Form1
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
            this.btneenviar = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.Mensaje = new System.Windows.Forms.Label();
            this.listParticipantes = new System.Windows.Forms.ListBox();
            this.txtnick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listconversacion = new System.Windows.Forms.ListBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btneenviar
            // 
            this.btneenviar.Location = new System.Drawing.Point(543, 336);
            this.btneenviar.Name = "btneenviar";
            this.btneenviar.Size = new System.Drawing.Size(75, 23);
            this.btneenviar.TabIndex = 0;
            this.btneenviar.Text = "Enviar";
            this.btneenviar.UseVisualStyleBackColor = true;
            this.btneenviar.Click += new System.EventHandler(this.btneenviar_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(83, 298);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(337, 20);
            this.txtmensaje.TabIndex = 1;
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(2, 298);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(47, 13);
            this.Mensaje.TabIndex = 2;
            this.Mensaje.Text = "Mensaje";
            // 
            // listParticipantes
            // 
            this.listParticipantes.FormattingEnabled = true;
            this.listParticipantes.Location = new System.Drawing.Point(478, 13);
            this.listParticipantes.Name = "listParticipantes";
            this.listParticipantes.Size = new System.Drawing.Size(188, 264);
            this.listParticipantes.TabIndex = 4;
            // 
            // txtnick
            // 
            this.txtnick.Location = new System.Drawing.Point(487, 298);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(179, 20);
            this.txtnick.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = " Nick";
            // 
            // listconversacion
            // 
            this.listconversacion.FormattingEnabled = true;
            this.listconversacion.Location = new System.Drawing.Point(52, 13);
            this.listconversacion.Name = "listconversacion";
            this.listconversacion.Size = new System.Drawing.Size(368, 264);
            this.listconversacion.TabIndex = 7;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(83, 338);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(743, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.listconversacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnick);
            this.Controls.Add(this.listParticipantes);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.btneenviar);
            this.Name = "Form1";
            this.Text = "Chat Univalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneenviar;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.ListBox listParticipantes;
        private System.Windows.Forms.TextBox txtnick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listconversacion;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
    }
}

