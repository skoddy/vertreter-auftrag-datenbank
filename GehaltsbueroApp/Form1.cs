using Gehaltsbuero.Models;
using Gehaltsbuero.;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gehaltsbuero
{
    public partial class Form1 : Form
    {
        public List<Vertreter> Vertreter;

        public static IGehalts Repository { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
