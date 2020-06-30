using Gehaltsbuero.Models;
using Gehaltsbuero.Repository;
using Gehaltsbuero.Repository.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gehaltsbuero
{
    public partial class Form1 : Form
    {
        public List<Vertreter> Vertreter;

        public static IGehaltsbueroRepository Repository { get; private set; }
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Vertreter vertreter = new Vertreter();
            vertreter.Vorname = textBox1.Text;
            vertreter.Nachname = textBox2.Text;
            Repository.Vertreter.Upsert(vertreter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var asd = Repository.Vertreter.Get();
            foreach (var a in asd)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
