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
using System.Windows.Shapes;

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for Transaction_Window.xaml
    /// </summary>
    public partial class Transaction_Window : Window
    {
        public Person Customer;
        public Product Jewelry;
        public Transaction_Window()
        {
            InitializeComponent();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    lstDetails.Items.Add(Customer.GetFullName() + " " + Jewelry.Name);
        //}

        private void TransClick (object sender, RoutedEventArgs e)
        {
            
        }
    }
}
