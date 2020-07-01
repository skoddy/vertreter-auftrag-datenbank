using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gehaltsbuero.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            GetVertreterList();
        }

        public ObservableCollection<VertreterViewModel> Vertreter { get; }
            = new ObservableCollection<VertreterViewModel>();

        private void GetVertreterList()
        {
            var vertreter = App.Repository.Vertreter.Get();
            if (vertreter == null)
            {
                return;
            }

            Vertreter.Clear();
            foreach (var c in vertreter)
            {
                Vertreter.Add(new VertreterViewModel(c));
            }
        }

        public void Sync()
        {
            foreach (var modifiedVertreter in Vertreter
                .Where(vertreter => vertreter.IsModified)
                .Select(vertreter => vertreter.Model))
            {
                App.Repository.Vertreter.Upsert(modifiedVertreter);
            }
            GetVertreterList();
        }
    }
}
