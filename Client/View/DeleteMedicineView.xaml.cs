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
    /// Логика взаимодействия для DeleteMedicineView.xaml
    /// </summary>
    public partial class DeleteMedicineView : UserControl
    {
        DeleteMedicineViewModel DeleteMedicineViewModel = new DeleteMedicineViewModel();
        public DeleteMedicineView()
        {
            InitializeComponent();
        }

        private async void DeleteMedicineButtonClick(object sender, RoutedEventArgs e)
        {
            var id = idTextBox.Text;
            await DeleteMedicineViewModel.DeleteMedicine(id);
        }
    }
}
