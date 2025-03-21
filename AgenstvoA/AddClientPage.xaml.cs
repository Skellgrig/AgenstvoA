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
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        private AddClientViewModel viewModel;
        public AddClientPage()
        {
            InitializeComponent();
            viewModel = new AddClientViewModel();
            DataContext = viewModel;
        }

        public AddClientPage(Клиенты client)
        {
            InitializeComponent();
            viewModel = new AddClientViewModel(client);
            DataContext = viewModel;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SaveClient();
        }
    }
}
