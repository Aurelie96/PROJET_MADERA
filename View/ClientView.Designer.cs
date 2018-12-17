namespace Madera
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
            this.lblBienvenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VueClient
            // 
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
            this.dgv_VueClient.Location = new System.Drawing.Point(-1, 119);
            this.dgv_VueClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_VueClient.Name = "dgv_VueClient";
            this.dgv_VueClient.RowTemplate.Height = 24;
            this.dgv_VueClient.Size = new System.Drawing.Size(634, 236);
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
            this.btnRafraichir.Location = new System.Drawing.Point(9, 78);
            this.btnRafraichir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(145, 28);
            this.btnRafraichir.TabIndex = 1;
            this.btnRafraichir.Text = "Rafraîchir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez saisir le nom du client :";
            // 
            // txtRechercherClient
            // 
            this.txtRechercherClient.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercherClient.Location = new System.Drawing.Point(385, 50);
            this.txtRechercherClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRechercherClient.Multiline = true;
            this.txtRechercherClient.Name = "txtRechercherClient";
            this.txtRechercherClient.Size = new System.Drawing.Size(164, 24);
            this.txtRechercherClient.TabIndex = 3;
            this.txtRechercherClient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(485, 78);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(145, 28);
            this.BtnAjouter.TabIndex = 4;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(13, 13);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(77, 22);
            this.lblBienvenue.TabIndex = 5;
            this.lblBienvenue.Text = "Bonjour, ";
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 366);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.txtRechercherClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.dgv_VueClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientView";
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
        private System.Windows.Forms.Label lblBienvenue;
    }
}

