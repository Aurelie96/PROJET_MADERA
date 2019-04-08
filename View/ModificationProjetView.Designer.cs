namespace Madera.View
{
    partial class ModificationProjetView
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
<<<<<<< HEAD
            this.TxtReferenceProjet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNomDevis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDateProjet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomProjet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.cbxNomCommercial = new System.Windows.Forms.ComboBox();
            this.cbxNomClient = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtReferenceProjet
            // 
            this.TxtReferenceProjet.Location = new System.Drawing.Point(417, 30);
            this.TxtReferenceProjet.Name = "TxtReferenceProjet";
            this.TxtReferenceProjet.Size = new System.Drawing.Size(150, 22);
            this.TxtReferenceProjet.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Référence Projet :";
            // 
            // TxtNomDevis
            // 
            this.TxtNomDevis.Location = new System.Drawing.Point(417, 280);
            this.TxtNomDevis.Name = "TxtNomDevis";
            this.TxtNomDevis.Size = new System.Drawing.Size(150, 22);
            this.TxtNomDevis.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nom Devis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nom Commercial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nom Client :";
            // 
            // TxtDateProjet
            // 
            this.TxtDateProjet.Location = new System.Drawing.Point(417, 130);
            this.TxtDateProjet.Name = "TxtDateProjet";
            this.TxtDateProjet.Size = new System.Drawing.Size(150, 22);
            this.TxtDateProjet.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date Projet :";
            // 
            // TxtNomProjet
            // 
            this.TxtNomProjet.Location = new System.Drawing.Point(417, 80);
            this.TxtNomProjet.Name = "TxtNomProjet";
            this.TxtNomProjet.Size = new System.Drawing.Size(150, 22);
            this.TxtNomProjet.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nom Projet :";
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(417, 328);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(150, 32);
            this.BtnSupprimer.TabIndex = 21;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(217, 328);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(150, 32);
            this.BtnModifier.TabIndex = 20;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // cbxNomCommercial
            // 
            this.cbxNomCommercial.FormattingEnabled = true;
            this.cbxNomCommercial.Location = new System.Drawing.Point(417, 230);
            this.cbxNomCommercial.Name = "cbxNomCommercial";
            this.cbxNomCommercial.Size = new System.Drawing.Size(150, 24);
            this.cbxNomCommercial.TabIndex = 40;
            // 
            // cbxNomClient
            // 
            this.cbxNomClient.FormattingEnabled = true;
            this.cbxNomClient.Location = new System.Drawing.Point(417, 180);
            this.cbxNomClient.Name = "cbxNomClient";
            this.cbxNomClient.Size = new System.Drawing.Size(150, 24);
            this.cbxNomClient.TabIndex = 41;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(747, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ModificationProjetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxNomClient);
            this.Controls.Add(this.cbxNomCommercial);
            this.Controls.Add(this.TxtReferenceProjet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNomDevis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDateProjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomProjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificationProjetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificationProjetView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtReferenceProjet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNomDevis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDateProjet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomProjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.ComboBox cbxNomCommercial;
        private System.Windows.Forms.ComboBox cbxNomClient;
        private System.Windows.Forms.Button btnClose;
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ModificationProjetView";
        }

        #endregion
>>>>>>> 998b72d722f998624b54343b4dbe0ab2b7585278
    }
}