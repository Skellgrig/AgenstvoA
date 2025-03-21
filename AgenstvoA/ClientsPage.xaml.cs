﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace AgenstvoA
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        private ClientsViewModel viewModel;

        public ClientsPage()
        {
            InitializeComponent();
            viewModel = new ClientsViewModel();
            DataContext = viewModel;
        }

        public Клиенты SelectedClient { get; set; }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedClient != null)
            {
                AddClientPage addClientPage = new AddClientPage(SelectedClient);
                NavigationService.Navigate(addClientPage);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedClient != null)
            {
                viewModel.DeleteClient(SelectedClient);
            }
        }
    }
}
