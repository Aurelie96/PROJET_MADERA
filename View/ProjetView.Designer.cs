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
            this.dgvNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdresseClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodePostalClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVilleClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.txtRechercherClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRafraichir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueProjet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VueProjet
            // 
            this.dgv_VueProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_VueProjet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VueProjet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomClient,
            this.dgvPrenomClient,
            this.dgvAdresseClient,
            this.dgvCodePostalClient,
            this.dgvVilleClient});
            this.dgv_VueProjet.Location = new System.Drawing.Point(12, 151);
            this.dgv_VueProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_VueProjet.Name = "dgv_VueProjet";
            this.dgv_VueProjet.RowTemplate.Height = 24;
            this.dgv_VueProjet.Size = new System.Drawing.Size(911, 290);
            this.dgv_VueProjet.TabIndex = 19;
            this.dgv_VueProjet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VueProjet_CellContentClick);
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
            // dgvAdresseClient
            // 
            this.dgvAdresseClient.HeaderText = "NomClient";
            this.dgvAdresseClient.Name = "dgvAdresseClient";
            // 
            // dgvCodePostalClient
            // 
            this.dgvCodePostalClient.HeaderText = "NomCommercial";
            this.dgvCodePostalClient.Name = "dgvCodePostalClient";
            // 
            // dgvVilleClient
            // 
            this.dgvVilleClient.HeaderText = "NomDevis";
            this.dgvVilleClient.Name = "dgvVilleClient";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(883, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjouter.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(730, 113);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(193, 34);
            this.BtnAjouter.TabIndex = 23;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // txtRechercherClient
            // 
            this.txtRechercherClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRechercherClient.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercherClient.Location = new System.Drawing.Point(525, 9);
            this.txtRechercherClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRechercherClient.Multiline = true;
            this.txtRechercherClient.Name = "txtRechercherClient";
            this.txtRechercherClient.Size = new System.Drawing.Size(217, 29);
            this.txtRechercherClient.TabIndex = 22;
            this.txtRechercherClient.TextChanged += new System.EventHandler(this.txtRechercherClient_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Veuillez saisir le nom du projet :";
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichir.Location = new System.Drawing.Point(12, 113);
            this.btnRafraichir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(193, 34);
            this.btnRafraichir.TabIndex = 20;
            this.btnRafraichir.Text = "Rafraîchir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // ProjetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.dgv_VueProjet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.txtRechercherClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRafraichir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjetView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VueProjet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VueProjet;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.TextBox txtRechercherClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdresseClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodePostalClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVilleClient;
    }
}