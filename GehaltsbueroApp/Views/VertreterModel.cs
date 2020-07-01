using Gehaltsbuero.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Gehaltsbuero.Views
{
    public class VertreterModel : BindableBase, INotifyPropertyChanged
    {
        public ObservableCollection<Auftrag> Auftrag { get; } = new ObservableCollection<Auftrag>();

        private Vertreter _model;

        public VertreterModel(Vertreter model = null)
        {
            Model = model ?? new Vertreter();
        }

        public Vertreter Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;
                    LoadAuftraege();
                    OnPropertyChanged(string.Empty);
                }
            }
        }
        


        public string Vorname
        {
            get => Model.Vorname;
            set
            {
                if (value != Model.Vorname)
                {
                    Model.Vorname = value;
                    IsModified = true;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Nachname
        {
            get => Model.Nachname;
            set
            {
                if (value != Model.Nachname)
                {
                    Model.Vorname = value;
                    IsModified = true;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Name => IstNeuerVertreter
                              && string.IsNullOrEmpty(Vorname)
                              && string.IsNullOrEmpty(Nachname) 
                              ? "Neuer Vertreter" : $"{Vorname} {Nachname}";

        public bool IsModified { get; set; }

        private bool _istNeuerVertreter;

        public bool IstNeuerVertreter
        {
            get => _istNeuerVertreter;
            set => Set(ref _istNeuerVertreter, value);
        }

        private void LoadVertreter()
        {
            LoadAuftraege();
            Model = App.Repository.Vertreter.Get(Model.Id);
        }

        private void LoadAuftraege()
        {
            var auftraege = App.Repository.Auftrag.GetForVertreter(Model.Id);
            Auftrag.Clear();
            foreach (var auftrag in auftraege)
            {
                Auftrag.Add(auftrag);
            }
        }
    }
}
