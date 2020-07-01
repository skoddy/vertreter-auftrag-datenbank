using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gehaltsbuero.Views
{
    public partial class VertreterListCtrl : UserControl
    {
        public MainModel MainModel => App.MainModel;

        private BindingSource bindingSource1 = new BindingSource();
        public VertreterListCtrl()
        {
            InitializeComponent();

        }
    }
}
