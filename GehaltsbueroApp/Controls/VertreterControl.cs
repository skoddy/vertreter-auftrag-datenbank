using System;
using System.Windows.Forms;
using Gehaltsbuero.Models;
using System.Collections.ObjectModel;
using Gehaltsbuero.ViewModels;
using System.Linq;
using Gehaltsbuero.Dialogs;

namespace Gehaltsbuero.Controls
{
    public partial class VertreterControl : UserControl
    {
        public MainViewModel ViewModel => App.ViewModel;

        public VertreterControl()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn nachnameCol = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn vornameCol = new DataGridViewTextBoxColumn();
            nachnameCol.Name = "Nachname";
            nachnameCol.DataPropertyName = "Nachname";
            vornameCol.Name = "Vorname";
            vornameCol.DataPropertyName = "Vorname";
            grdVertreter.Columns.AddRange(nachnameCol, vornameCol);

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            grdVertreter.AutoGenerateColumns = false;
            grdVertreter.DataSource = null;
            grdVertreter.DataSource = ViewModel.Vertreter;
        }

        private void btnNeuerVertreter_Click(object sender, EventArgs e)
        {
            NeuerVertreter neuerVertreter = new NeuerVertreter();
            neuerVertreter.ShowDialog();
            if (neuerVertreter.DialogResult == DialogResult.OK)
            {
                RefreshGrid();
                neuerVertreter.Dispose();
            }
            else
            {
                neuerVertreter.Dispose();
            }

        }
    }
}
