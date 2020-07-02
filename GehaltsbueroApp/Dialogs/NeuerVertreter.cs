using Gehaltsbuero.Models;
using Gehaltsbuero.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gehaltsbuero.Dialogs
{
    public partial class NeuerVertreter : Form
    {
        public VertreterViewModel ViewModel { get; set; }

        public NeuerVertreter()
        {
            InitializeComponent();
        }

        private void btnAddVertreter_Click(object sender, EventArgs e)
        {
            ViewModel.Save();
            Close();
        }

        private void NeuerVertreter_Load(object sender, EventArgs e)
        {
            ViewModel = new VertreterViewModel
            {
                IsNew = true
            };

            tbNachname
                .DataBindings
                .Add(new Binding("Text", ViewModel, "Nachname", false));
            tbVorname
                .DataBindings
                .Add(new Binding("Text", ViewModel, "Vorname", false));
        }
    }
}
