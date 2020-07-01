using Gehaltsbuero.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gehaltsbuero.Views
{
    public class MainModel : BindableBase
    {
        public MainModel()
        {
            Task.Run(LoadVertreter);
        }
        public ObservableCollection<VertreterModel> Vertreter { get; }
            = new ObservableCollection<VertreterModel>();

        public async Task LoadVertreter()
        {

            var customers = await App.Repository.Vertreter.GetAsync();
            if (customers == null)
            {
                return;
            }


            Vertreter.Clear();
            foreach (var c in customers)
            {
                Vertreter.Add(new VertreterModel(c));
            }


        }
    }
}
