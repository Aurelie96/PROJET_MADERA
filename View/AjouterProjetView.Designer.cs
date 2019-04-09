namespace Madera.View
{
    partial class AjouterProjetView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxNomClient = new System.Windows.Forms.ComboBox();
            this.cbxNomCommercial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomProjet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(516, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxNomClient
            // 
            this.cbxNomClient.FormattingEnabled = true;
            this.cbxNomClient.Location = new System.Drawing.Point(315, 219);
            this.cbxNomClient.Name = "cbxNomClient";
            this.cbxNomClient.Size = new System.Drawing.Size(150, 24);
            this.cbxNomClient.TabIndex = 56;
            // 
            // cbxNomCommercial
            // 
            this.cbxNomCommercial.FormattingEnabled = true;
            this.cbxNomCommercial.Location = new System.Drawing.Point(315, 269);
            this.cbxNomCommercial.Name = "cbxNomCommercial";
            this.cbxNomCommercial.Size = new System.Drawing.Size(150, 24);
            this.cbxNomCommercial.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nom Commercial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nom Client :";
            // 
            // TxtNomProjet
            // 
            this.TxtNomProjet.Location = new System.Drawing.Point(315, 174);
            this.TxtNomProjet.Name = "TxtNomProjet";
            this.TxtNomProjet.Size = new System.Drawing.Size(150, 22);
            this.TxtNomProjet.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nom Projet :";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(221, 333);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(150, 32);
            this.BtnAjouter.TabIndex = 44;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // AjouterProjetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 431);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxNomClient);
            this.Controls.Add(this.cbxNomCommercial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNomProjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAjouter);
            this.Name = "AjouterProjetView";
            this.Text = "AjouterProjetView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbxNomClient;
        private System.Windows.Forms.ComboBox cbxNomCommercial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomProjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAjouter;
    }
}