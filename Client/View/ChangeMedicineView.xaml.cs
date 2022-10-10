using Client.Models;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client.View
{
    /// <summary>
    /// Логика взаимодействия для ChangeMedicine.xaml
    /// </summary>
    public partial class ChangeMedicineView : UserControl
    {
        ChangeMedicineViewModel ChangeMedicineViewModel = new ChangeMedicineViewModel();
        public ChangeMedicineView()
        {
            InitializeComponent();
        }

        private async void ChangeMedicineButtonClick(object sender, RoutedEventArgs e)
        {
            var medicine = new MedicineModel();
            medicine.Id = int.Parse(idChangedTextBox.Text);
            medicine.Name = nameChangedTextBox.Text;
            medicine.Description = descriptionChangedTextBox.Text;
            await ChangeMedicineViewModel.ChangeMedicine(medicine, idChangedTextBox.Text);
        }
    }
}
