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
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.TxtCodePostalClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdresseClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrenomClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(291, 201);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(187, 43);
            this.BtnAjouter.TabIndex = 55;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            // 
            // TxtCodePostalClient
            // 
            this.TxtCodePostalClient.Location = new System.Drawing.Point(425, 158);
            this.TxtCodePostalClient.Name = "TxtCodePostalClient";
            this.TxtCodePostalClient.Size = new System.Drawing.Size(150, 22);
            this.TxtCodePostalClient.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nom Commercial :";
            // 
            // TxtAdresseClient
            // 
            this.TxtAdresseClient.Location = new System.Drawing.Point(425, 108);
            this.TxtAdresseClient.Name = "TxtAdresseClient";
            this.TxtAdresseClient.Size = new System.Drawing.Size(150, 22);
            this.TxtAdresseClient.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nom Client :";
            // 
            // TxtPrenomClient
            // 
            this.TxtPrenomClient.Location = new System.Drawing.Point(425, 58);
            this.TxtPrenomClient.Name = "TxtPrenomClient";
            this.TxtPrenomClient.Size = new System.Drawing.Size(150, 22);
            this.TxtPrenomClient.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date Projet";
            // 
            // TxtNomClient
            // 
            this.TxtNomClient.Location = new System.Drawing.Point(425, 8);
            this.TxtNomClient.Name = "TxtNomClient";
            this.TxtNomClient.Size = new System.Drawing.Size(150, 22);
            this.TxtNomClient.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nom Projet :";
            // 
            // AjouterProjetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.TxtCodePostalClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAdresseClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPrenomClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterProjetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterProjetView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.TextBox TxtCodePostalClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdresseClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrenomClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomClient;
        private System.Windows.Forms.Label label1;
    }
}