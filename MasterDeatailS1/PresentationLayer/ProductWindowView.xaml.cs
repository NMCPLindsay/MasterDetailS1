using MasterDeatailS1.Models;
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

namespace MasterDeatailS1.PresentationLayer
{
    /// <summary>
    /// Interaction logic for ProductWindowView.xaml
    /// </summary>
    public partial class ProductWindowView : Window
    {
        ProductWindowPresenter _productWindowPresenter;

        public ProductWindowView(ProductWindowPresenter productWindowPresenter)
        {
            _productWindowPresenter = productWindowPresenter;
            DataContext = _productWindowPresenter;
            InitializeComponent();
        }

        private void Button_Quit_Click(object sender, RoutedEventArgs e)
        {
            _productWindowPresenter.QuitApplication();
        }
    }
}
