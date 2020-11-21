﻿using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            this.InitializeComponent();
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}