namespace UIWindows
{
    partial class DisplayInfoForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomLabel = new System.Windows.Forms.Label();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(25, 67);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(35, 13);
            this.NomLabel.TabIndex = 0;
            this.NomLabel.Text = "label1";
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Location = new System.Drawing.Point(25, 112);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(35, 13);
            this.PrenomLabel.TabIndex = 1;
            this.PrenomLabel.Text = "label2";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(28, 27);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(35, 13);
            this.CodeLabel.TabIndex = 2;
            this.CodeLabel.Text = "label1";
            // 
            // DisplayInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.NomLabel);
            this.Name = "DisplayInfoForm";
            this.Text = "Profil utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label NomLabel;
        public System.Windows.Forms.Label PrenomLabel;
        public System.Windows.Forms.Label CodeLabel;

    }
}