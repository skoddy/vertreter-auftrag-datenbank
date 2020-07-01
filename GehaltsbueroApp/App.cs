using Gehaltsbuero.Models;
using Gehaltsbuero.Repository;
using Gehaltsbuero.Repository.Sql;
using Gehaltsbuero.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gehaltsbuero
{
    public partial class App : Form
    {
        public List<Vertreter> Vertreter;
        public static MainModel MainModel { get; set; }
        public Vertreter ver;
        public static IGehaltsbueroRepository Repository { get; private set; }
        public App() => InitializeComponent();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var dbOptions = 
                new DbContextOptionsBuilder<GehaltsbueroContext>()
                .UseMySQL("server=localhost;database=gehaltsbuero;user=root;password=root");

            Repository = new SqlGehaltsbueroRepository(dbOptions);
            MainModel  = new MainModel();
            Task.Run(RefreshCustomerAsync);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vertreter vertreter = new Vertreter();
            vertreter.Vorname = textBox1.Text;
            vertreter.Nachname = textBox2.Text;
            Repository.Vertreter.Upsert(vertreter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var a in Vertreter)
            {
                Console.WriteLine(a.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VertreterListCtrl vertreterListCtrl = new VertreterListCtrl();
            panel1.Controls.Add(vertreterListCtrl);
        }

        public async Task RefreshCustomerAsync()
        {

           var ver = await App.Repository.Vertreter.GetAsync();
            foreach (var a in ver) 
            {
                Vertreter.Add(a);
            }
        }
    }
}
