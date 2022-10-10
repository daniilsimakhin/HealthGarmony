﻿using Client.Models;
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
    /// Логика взаимодействия для AddMedicineView.xaml
    /// </summary>
    public partial class AddMedicineView : UserControl
    {
        AddMedicineViewModel AddMedicineViewModel = new AddMedicineViewModel();

        public AddMedicineView()
        {
            InitializeComponent();
        }
        private async void AddMedicineButtonClick(object sender, RoutedEventArgs e)
        {
            var medicine = new MedicineModel();
            medicine.Name = nameTextBox.Text;
            medicine.Description = descriptionTextBox.Text;
            await AddMedicineViewModel.AddMedicine(medicine);
        }

    }
}
