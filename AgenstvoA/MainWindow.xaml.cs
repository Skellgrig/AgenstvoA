using System;
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

namespace AgenstvoA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClientsList_Click(object sender, RoutedEventArgs e)
        {
            ClientsPage clientsPage = new ClientsPage();
            MainContent.Navigate(clientsPage);
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientPage addClientPage = new AddClientPage();
            MainContent.Navigate(addClientPage);
        }

        private void LoansList_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отобразить список кредитов
        }

        private void IssueLoan_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Открыть окно выдачи кредита
        }

        private void PaymentsList_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отобразить список платежей
        }

        private void MakePayment_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Открыть окно внесения платежа
        }

        private void EmployeesList_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отобразить список сотрудников
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Открыть окно добавления сотрудника
        }

        private void LoansHistory_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отобразить историю кредитов
        }
    }
}
