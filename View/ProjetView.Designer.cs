namespace Madera.View
{
    partial class ProjetView
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
            this.dgv_VueProjet = new System.Windows.Forms.DataGridView();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.txtRechercherProjet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.dgvNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueProjet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VueProjet
            // 
            this.dgv_VueProjet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VueProjet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomClient,
            this.dgvPrenomClient});
            this.dgv_VueProjet.Location = new System.Drawing.Point(12, 145);
            this.dgv_VueProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_VueProjet.Name = "dgv_VueProjet";
            this.dgv_VueProjet.RowTemplate.Height = 24;
            this.dgv_VueProjet.Size = new System.Drawing.Size(811, 290);
            this.dgv_VueProjet.TabIndex = 6;
            this.dgv_VueProjet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VueClient_CellContentClick);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(7, 9);
            this.lblBienvenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(101, 27);
            this.lblBienvenue.TabIndex = 11;
            this.lblBienvenue.Text = "Bonjour, ";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(626, 95);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(193, 34);
            this.BtnAjouter.TabIndex = 10;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // txtRechercherProjet
            // 
            this.txtRechercherProjet.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercherProjet.Location = new System.Drawing.Point(492, 61);
            this.txtRechercherProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRechercherProjet.Multiline = true;
            this.txtRechercherProjet.Name = "txtRechercherProjet";
            this.txtRechercherProjet.Size = new System.Drawing.Size(217, 29);
            this.txtRechercherProjet.TabIndex = 9;
            this.txtRechercherProjet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Veuillez saisir le nom du projet :";
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichir.Location = new System.Drawing.Point(12, 95);
            this.btnRafraichir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(193, 34);
            this.btnRafraichir.TabIndex = 7;
            this.btnRafraichir.Text = "Rafraîchir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // dgvNomClient
            // 
            this.dgvNomClient.HeaderText = "Nom";
            this.dgvNomClient.Name = "dgvNomClient";
            // 
            // dgvPrenomClient
            // 
            this.dgvPrenomClient.HeaderText = "Date";
            this.dgvPrenomClient.Name = "dgvPrenomClient";
            // 
            // ProjetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 446);
            this.Controls.Add(this.dgv_VueProjet);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.txtRechercherProjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRafraichir);
            this.Name = "ProjetView";
            this.Text = "ProjetView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueProjet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VueProjet;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.TextBox txtRechercherProjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrenomClient;
    }
}