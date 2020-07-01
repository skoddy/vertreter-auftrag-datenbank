using System;
using System.Windows.Forms;
using Gehaltsbuero.Models;
using System.Collections.ObjectModel;
using Gehaltsbuero.ViewModels;

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
            nachnameCol.ReadOnly = true;
            vornameCol.Name = "Vorname";
            vornameCol.DataPropertyName = "Vorname";
            vornameCol.ReadOnly = true;
            grdVertreter.Columns.AddRange(nachnameCol, vornameCol);
            grdVertreter.AutoGenerateColumns = false;
            grdVertreter.DataSource = ViewModel.Vertreter;
        }


        private void btnAddVertreter_Click(object sender, EventArgs e)
        {
            Vertreter vertreter = new Vertreter();
            vertreter.Vorname = tbVorname.Text;
            vertreter.Nachname = tbNachname.Text;
            App.Repository.Vertreter.Upsert(vertreter);
        }
    }
}
