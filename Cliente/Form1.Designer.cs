namespace Cliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPuerto = new System.Windows.Forms.ToolStripTextBox();
            this.btnHORA = new System.Windows.Forms.Button();
            this.btnFECHA = new System.Windows.Forms.Button();
            this.btnTODO = new System.Windows.Forms.Button();
            this.btnAPAGAR = new System.Windows.Forms.Button();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.txtIP,
            this.toolStripMenuItem2,
            this.txtPuerto});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 23);
            this.toolStripMenuItem1.Text = "IP :";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 23);
            this.toolStripMenuItem2.Text = "Puerto :";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 23);
            // 
            // btnHORA
            // 
            this.btnHORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHORA.Location = new System.Drawing.Point(222, 119);
            this.btnHORA.Name = "btnHORA";
            this.btnHORA.Size = new System.Drawing.Size(79, 39);
            this.btnHORA.TabIndex = 1;
            this.btnHORA.Text = "HORA";
            this.btnHORA.UseVisualStyleBackColor = true;
            // 
            // btnFECHA
            // 
            this.btnFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFECHA.Location = new System.Drawing.Point(341, 119);
            this.btnFECHA.Name = "btnFECHA";
            this.btnFECHA.Size = new System.Drawing.Size(79, 39);
            this.btnFECHA.TabIndex = 2;
            this.btnFECHA.Text = "FECHA";
            this.btnFECHA.UseVisualStyleBackColor = true;
            // 
            // btnTODO
            // 
            this.btnTODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTODO.Location = new System.Drawing.Point(286, 164);
            this.btnTODO.Name = "btnTODO";
            this.btnTODO.Size = new System.Drawing.Size(79, 39);
            this.btnTODO.TabIndex = 3;
            this.btnTODO.Text = "TODO";
            this.btnTODO.UseVisualStyleBackColor = true;
            // 
            // btnAPAGAR
            // 
            this.btnAPAGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPAGAR.Location = new System.Drawing.Point(16, 223);
            this.btnAPAGAR.Name = "btnAPAGAR";
            this.btnAPAGAR.Size = new System.Drawing.Size(91, 39);
            this.btnAPAGAR.TabIndex = 4;
            this.btnAPAGAR.Text = "APAGAR";
            this.btnAPAGAR.UseVisualStyleBackColor = true;
            // 
            // txtComando
            // 
            this.txtComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtComando.Location = new System.Drawing.Point(222, 87);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(198, 26);
            this.txtComando.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mensaje para el servidor :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComando);
            this.Controls.Add(this.btnAPAGAR);
            this.Controls.Add(this.btnTODO);
            this.Controls.Add(this.btnFECHA);
            this.Controls.Add(this.btnHORA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cliente de Hora y Fecha";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txtIP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox txtPuerto;
        private System.Windows.Forms.Button btnHORA;
        private System.Windows.Forms.Button btnFECHA;
        private System.Windows.Forms.Button btnTODO;
        private System.Windows.Forms.Button btnAPAGAR;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label label1;
    }
}

