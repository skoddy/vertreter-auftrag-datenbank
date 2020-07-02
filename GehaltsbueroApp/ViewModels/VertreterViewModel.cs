using Gehaltsbuero.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gehaltsbuero.ViewModels
{
    public class VertreterViewModel : BindableBase, IEditableObject
    {
        public ObservableCollection<Auftrag> Auftraege { get; } = new ObservableCollection<Auftrag>();

        public VertreterViewModel(Vertreter model = null)
        {
            Model = model ?? new Vertreter();
        }

        private Vertreter _model;


        public Vertreter Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;
                    RefreshAuftraege();

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

        /// <summary>
        /// Gets or sets the customer's last name.
        /// </summary>
        public string Nachname
        {
            get => Model.Nachname;
            set
            {
                if (value != Model.Nachname)
                {
                    Model.Nachname = value;
                    IsModified = true;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Name => IsNew && string.IsNullOrEmpty(Vorname)
    && string.IsNullOrEmpty(Nachname) ? "Neuer Vertreter" : $"{Vorname} {Nachname}";

        public bool IsModified { get; set; }
        private bool _isNew;


        public bool IsNew
        {
            get => _isNew;
            set => Set(ref _isNew, value);
        }

        private bool _isInEdit = false;


        public bool IsInEdit
        {
            get => _isInEdit;
            set => Set(ref _isInEdit, value);
        }

        public void RefreshVertreter()
        {
            RefreshAuftraege();
            Model = App.Repository.Vertreter.Get(Model.Id);
        }

        public void RefreshAuftraege()
        {
            var auftraege = App.Repository.Auftrag.GetForVertreter(Model.Id);

            Auftraege.Clear();
            foreach (var auftrag in auftraege)
            {
                Auftraege.Add(auftrag);
            }

        }
        public void Save()
        {
            IsModified = false;
            if (IsNew)
            {
                IsNew = false;
                App.ViewModel.Vertreter.Add(this);
            }
            
            App.Repository.Vertreter.Upsert(Model);
        }

        public event EventHandler AddNewVertreterCanceled;

        public void CancelEdits()
        {
            if (IsNew)
            {
                AddNewVertreterCanceled?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                RevertChanges();
            }
        }

        public void RevertChanges()
        {
            IsInEdit = false;
            if (IsModified)
            {
                RefreshVertreter();
                IsModified = false;
            }
        }

        public void BeginEdit()
        {
            
        }

        public void EndEdit()
        {
            Save();
        }

        public void CancelEdit()
        {
            CancelEdits();
        }
    }
}
