using Client.Models;
using Client.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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
    /// Логика взаимодействия для ListMedicineView.xaml
    /// </summary>
    public partial class ListMedicineView : UserControl
    {
        ListMedicineViewModel listMedicineViewModel = new ListMedicineViewModel();

        public ListMedicineView()
        {
            InitializeComponent();
        }

        private async void UpdateTableButtonClick(object sender, RoutedEventArgs e)
        {            
            medicinesGrid.ItemsSource = await listMedicineViewModel.UpdateTable();
            //MessageBox.Show("Кнопка нажата");
        }
    }
}
