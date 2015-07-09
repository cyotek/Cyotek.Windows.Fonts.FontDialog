﻿/* Cyotek FontDialog
 * http://cyotek.com
 * http://cyotek.com/blog/tag/fontdialog
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class MainMenuForm : AboutDialog
  {
    #region Constructors

    public MainMenuForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      TabPage demoPage;

      base.OnLoad(e);

      demoPage = new TabPage
                 {
                   UseVisualStyleBackColor = true,
                   Padding = new Padding(9),
                   Text = "Demonstrations"
                 };

      demoGroupBox.Dock = DockStyle.Fill;
      demoPage.Controls.Add(demoGroupBox);

      this.TabControl.TabPages.Insert(0, demoPage);
      this.TabControl.SelectedTab = demoPage;

      this.Text = FileVersionInfo.GetVersionInfo(this.GetType().Assembly.Location).Comments;
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
    /// </summary>
    /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      generalDemonstrationButton.Focus();
    }

    private void generalDemonstrationButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<GeneralDemonstrationForm>();
    }

    private void ShowDemo<T>() where T : Form, new()
    {
      Cursor.Current = Cursors.WaitCursor;

      using (Form form = new T())
      {
        form.ShowDialog(this);
      }
    }

    #endregion
  }
}
