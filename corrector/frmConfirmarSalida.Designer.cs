namespace corrector
{
    partial class frmConfirmarSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmarSalida));
            this.btnConfirmarSalida = new System.Windows.Forms.Button();
            this.btnCancelarSalida = new System.Windows.Forms.Button();
            this.chkNoConfirmarSalida = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarSalida
            // 
            this.btnConfirmarSalida.Location = new System.Drawing.Point(207, 97);
            this.btnConfirmarSalida.Name = "btnConfirmarSalida";
            this.btnConfirmarSalida.Size = new System.Drawing.Size(79, 31);
            this.btnConfirmarSalida.TabIndex = 0;
            this.btnConfirmarSalida.Text = "&Sí";
            this.btnConfirmarSalida.UseVisualStyleBackColor = true;
            this.btnConfirmarSalida.Click += new System.EventHandler(this.btnConfirmarSalida_Click);
            // 
            // btnCancelarSalida
            // 
            this.btnCancelarSalida.Location = new System.Drawing.Point(303, 97);
            this.btnCancelarSalida.Name = "btnCancelarSalida";
            this.btnCancelarSalida.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarSalida.TabIndex = 1;
            this.btnCancelarSalida.Text = "&No";
            this.btnCancelarSalida.UseVisualStyleBackColor = true;
            this.btnCancelarSalida.Click += new System.EventHandler(this.btnCancelarSalida_Click);
            // 
            // chkNoConfirmarSalida
            // 
            this.chkNoConfirmarSalida.AutoSize = true;
            this.chkNoConfirmarSalida.Location = new System.Drawing.Point(12, 111);
            this.chkNoConfirmarSalida.Name = "chkNoConfirmarSalida";
            this.chkNoConfirmarSalida.Size = new System.Drawing.Size(128, 17);
            this.chkNoConfirmarSalida.TabIndex = 2;
            this.chkNoConfirmarSalida.Text = "No confirmar la salida";
            this.chkNoConfirmarSalida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Salir del corrector?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::corrector.Properties.Resources.faq_icon_48;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 66);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmConfirmarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 145);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNoConfirmarSalida);
            this.Controls.Add(this.btnCancelarSalida);
            this.Controls.Add(this.btnConfirmarSalida);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmarSalida";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Salida";
            this.Load += new System.EventHandler(this.frmConfirmarSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarSalida;
        private System.Windows.Forms.Button btnCancelarSalida;
        private System.Windows.Forms.CheckBox chkNoConfirmarSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}