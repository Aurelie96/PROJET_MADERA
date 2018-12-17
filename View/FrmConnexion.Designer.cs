namespace Madera.View
{
    partial class FrmConnexion
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
            this.grpConnexion = new System.Windows.Forms.GroupBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.grpConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnexion
            // 
            this.grpConnexion.Controls.Add(this.btnConnexion);
            this.grpConnexion.Controls.Add(this.lblMdp);
            this.grpConnexion.Controls.Add(this.tbxMdp);
            this.grpConnexion.Controls.Add(this.lblIdentifiant);
            this.grpConnexion.Controls.Add(this.tbxIdentifiant);
            this.grpConnexion.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConnexion.Location = new System.Drawing.Point(12, 77);
            this.grpConnexion.Name = "grpConnexion";
            this.grpConnexion.Size = new System.Drawing.Size(380, 200);
            this.grpConnexion.TabIndex = 0;
            this.grpConnexion.TabStop = false;
            this.grpConnexion.Text = "Connexion";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(234, 164);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(140, 30);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(124, 56);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(250, 27);
            this.tbxIdentifiant.TabIndex = 0;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(6, 59);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(91, 20);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(6, 96);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(112, 20);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(124, 93);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.PasswordChar = '*';
            this.tbxMdp.Size = new System.Drawing.Size(250, 27);
            this.tbxMdp.TabIndex = 1;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.grpConnexion);
            this.Name = "FrmConnexion";
            this.grpConnexion.ResumeLayout(false);
            this.grpConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnexion;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox tbxIdentifiant;
    }
}