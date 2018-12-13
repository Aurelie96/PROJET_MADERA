using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class CodeRequestForm : Form
    {
        private UIViewer owner;

        public CodeRequestForm(UIViewer caller)
        {
            owner = caller;
            InitializeComponent();
            loadListTypes(owner.Manager.LoadListType());
        }

        private void CodeRequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.Manager.Code = userCodeTextBox.Text;
            owner.Manager.Type = typeComboBox.Text;
            //e.Cancel = !owner.Manager.Validate();
        }

        private void loadListTypes(List<string> types)
        {
            foreach (string type in types)
            {
                typeComboBox.Items.Add(type);
            }
        }
    }
}