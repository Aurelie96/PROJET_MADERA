namespace UIWindows
{
    partial class CodeRequestForm
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
            this.userCodeLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.userCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.MessageLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userCodeLabel
            // 
            this.userCodeLabel.AutoSize = true;
            this.userCodeLabel.Location = new System.Drawing.Point(13, 94);
            this.userCodeLabel.Name = "userCodeLabel";
            this.userCodeLabel.Size = new System.Drawing.Size(79, 13);
            this.userCodeLabel.TabIndex = 0;
            this.userCodeLabel.Text = "Code utilisateur";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(104, 148);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // userCodeTextBox
            // 
            this.userCodeTextBox.Location = new System.Drawing.Point(104, 94);
            this.userCodeTextBox.Name = "userCodeTextBox";
            this.userCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.userCodeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(104, 52);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(150, 21);
            this.typeComboBox.TabIndex = 4;
            // 
            // MessageLable
            // 
            this.MessageLable.AutoSize = true;
            this.MessageLable.ForeColor = System.Drawing.Color.Red;
            this.MessageLable.Location = new System.Drawing.Point(19, 13);
            this.MessageLable.Name = "MessageLable";
            this.MessageLable.Size = new System.Drawing.Size(0, 13);
            this.MessageLable.TabIndex = 5;
            // 
            // CodeRequestForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.ControlBox = false;
            this.Controls.Add(this.MessageLable);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCodeTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.userCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeRequestForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identification du profil recherché";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeRequestForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userCodeLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label MessageLable;
        public System.Windows.Forms.ComboBox typeComboBox;
        public System.Windows.Forms.TextBox userCodeTextBox;
    }
}

