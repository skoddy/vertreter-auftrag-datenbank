using Gehaltsbuero.Controls;
using Gehaltsbuero.Models;
using Gehaltsbuero.Repository;
using Gehaltsbuero.Repository.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gehaltsbuero
{
    public partial class App : Form
    {
        public List<Vertreter> Vertreter;

        public static IGehaltsbueroRepository Repository { get; private set; }

        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var dbOptions = 
                new DbContextOptionsBuilder<GehaltsbueroContext>()
                .UseMySQL("server=localhost;database=gehaltsbuero;user=root;password=root");

            Repository = new SqlGehaltsbueroRepository(dbOptions);

        }

        private void btnShowVertreter_Click(object sender, EventArgs e)
        {
            VertreterControl vertreterControl = new VertreterControl();
            ToggleControl(vertreterControl);
        }

        private void btnShowAuftraege_Click(object sender, EventArgs e)
        {
            AuftragControl auftragControl = new AuftragControl();
            ToggleControl(auftragControl);
        }

        private void ToggleControl(Control control)
        {
            foreach (Control c in panel1.Controls.OfType<UserControl>())
            {
                panel1.Controls.Remove(c);
            }

            panel1.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.BringToFront();
        }
    }
}
