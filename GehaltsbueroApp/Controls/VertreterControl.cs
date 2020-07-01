using System;
using System.Windows.Forms;
using Gehaltsbuero.Models;
using System.Collections.ObjectModel;

namespace Gehaltsbuero.Controls
{
    public partial class VertreterControl : UserControl
    {
        public Collection<Vertreter> Vertreter { get; }
            = new Collection<Vertreter>();

        public VertreterControl()
        {
            InitializeComponent();
            LoadVertreter();
        }

        private void LoadVertreter()
        {
            Vertreter.Clear();
            var vertreter = App.Repository.Vertreter.Get();
            foreach (var v in vertreter)
            {
                Vertreter.Add(v);
            }
        }

        private void PopulateGrid()
        {
            LoadVertreter();
            grdVertreter.Rows.Clear();
            foreach (var v in Vertreter)
            {
                grdVertreter.Rows.Add(v.Nachname, v.Vorname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnAddVertreter_Click(object sender, EventArgs e)
        {
            Vertreter vertreter = new Vertreter();
            vertreter.Vorname = tbVorname.Text;
            vertreter.Nachname = tbNachname.Text;
            App.Repository.Vertreter.Upsert(vertreter);
            
            PopulateGrid();
        }
    }
}
