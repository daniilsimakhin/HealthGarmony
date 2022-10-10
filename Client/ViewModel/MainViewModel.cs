using Client.Core;
using Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand AddViewCommand { get; set; }
        public RelayCommand ChangeViewCommand { get; set; }
        public RelayCommand DeleteViewCommand { get; set; }
        public RelayCommand ListViewCommand { get; set; }

        public AddMedicineViewModel AddMedicineViewModel { get; set; }
        public ChangeMedicineViewModel ChangeMedicineViewModel { get; set; }
        public DeleteMedicineViewModel DeleteMedicineViewModel { get; set; }
        public ListMedicineViewModel ListMedicineViewModel { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AddMedicineViewModel = new AddMedicineViewModel();
            ChangeMedicineViewModel = new ChangeMedicineViewModel();
            DeleteMedicineViewModel = new DeleteMedicineViewModel();            
            ListMedicineViewModel = new ListMedicineViewModel();

            CurrentView = ListMedicineViewModel;

            AddViewCommand = new RelayCommand(o =>
            {
                CurrentView = AddMedicineViewModel;
            });

            ChangeViewCommand = new RelayCommand(o =>
            {
                CurrentView = ChangeMedicineViewModel;
            });

            DeleteViewCommand = new RelayCommand(o =>
            {
                CurrentView = DeleteMedicineViewModel;
            });

            ListViewCommand = new RelayCommand(o =>
            {
                CurrentView = ListMedicineViewModel;
            });
        }
    }
}
