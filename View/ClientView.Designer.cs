﻿namespace Madera
{
    partial class ClientView
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
            this.dgv_VueClient = new System.Windows.Forms.DataGridView();
            this.dgvNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdresseClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodePostalClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVilleClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmailClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFaxClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMobileClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercherClient = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VueClient
            // 
            this.dgv_VueClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_VueClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VueClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomClient,
            this.dgvPrenomClient,
            this.dgvAdresseClient,
            this.dgvCodePostalClient,
            this.dgvVilleClient,
            this.dgvEmailClient,
            this.dgvFaxClient,
            this.dgvMobileClient});
            this.dgv_VueClient.Location = new System.Drawing.Point(12, 148);
            this.dgv_VueClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_VueClient.Name = "dgv_VueClient";
            this.dgv_VueClient.RowTemplate.Height = 24;
            this.dgv_VueClient.Size = new System.Drawing.Size(840, 290);
            this.dgv_VueClient.TabIndex = 0;
            this.dgv_VueClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VueClient_CellContentClick);
            // 
            // dgvNomClient
            // 
            this.dgvNomClient.HeaderText = "Nom";
            this.dgvNomClient.Name = "dgvNomClient";
            // 
            // dgvPrenomClient
            // 
            this.dgvPrenomClient.HeaderText = "Prénom";
            this.dgvPrenomClient.Name = "dgvPrenomClient";
            // 
            // dgvAdresseClient
            // 
            this.dgvAdresseClient.HeaderText = "Adresse";
            this.dgvAdresseClient.Name = "dgvAdresseClient";
            // 
            // dgvCodePostalClient
            // 
            this.dgvCodePostalClient.HeaderText = "Code Postal";
            this.dgvCodePostalClient.Name = "dgvCodePostalClient";
            // 
            // dgvVilleClient
            // 
            this.dgvVilleClient.HeaderText = "Ville";
            this.dgvVilleClient.Name = "dgvVilleClient";
            // 
            // dgvEmailClient
            // 
            this.dgvEmailClient.HeaderText = "Email";
            this.dgvEmailClient.Name = "dgvEmailClient";
            // 
            // dgvFaxClient
            // 
            this.dgvFaxClient.HeaderText = "Fax";
            this.dgvFaxClient.Name = "dgvFaxClient";
            // 
            // dgvMobileClient
            // 
            this.dgvMobileClient.HeaderText = "Mobile";
            this.dgvMobileClient.Name = "dgvMobileClient";
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichir.Location = new System.Drawing.Point(12, 110);
            this.btnRafraichir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(193, 34);
            this.btnRafraichir.TabIndex = 1;
            this.btnRafraichir.Text = "Rafraîchir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez saisir le nom du client :";
            // 
            // txtRechercherClient
            // 
            this.txtRechercherClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRechercherClient.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercherClient.Location = new System.Drawing.Point(490, 6);
            this.txtRechercherClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRechercherClient.Multiline = true;
            this.txtRechercherClient.Name = "txtRechercherClient";
            this.txtRechercherClient.Size = new System.Drawing.Size(217, 29);
            this.txtRechercherClient.TabIndex = 3;
            this.txtRechercherClient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjouter.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(659, 110);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(193, 34);
            this.BtnAjouter.TabIndex = 4;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(812, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.txtRechercherClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.dgv_VueClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdresseClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodePostalClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVilleClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmailClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFaxClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMobileClient;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercherClient;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button btnClose;
    }
}

