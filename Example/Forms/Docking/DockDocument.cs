﻿using DarkUI.Config;
using DarkUI.Docking;
using DarkUI.Forms;
using System.Windows.Forms;

namespace Example
{
    public partial class DockDocument : DarkDocument
    {
        #region Constructor Region

        public DockDocument(string text)
        {
            InitializeComponent();

            DockText = text;

            // Workaround to stop the textbox from highlight all text.
            txtDocument.SelectionStart = txtDocument.Text.Length;
        }

        #endregion

        #region Event Handler Region

        public override void Close()
        {
            var result = DarkMessageBox.ShowWarning(@"You will lose any unsaved changes. Continue?", @"Close document", DarkDialogButton.YesNo);
            if (result == DialogResult.No)
                return;

            base.Close();
        }

        #endregion
    }
}
