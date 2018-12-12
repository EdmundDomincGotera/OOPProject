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
    /// Interaction logic for Add_Customer.xaml
    /// </summary>
    public partial class Add_Customer : Window
    {
        public Add_Customer()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Transaction_Window transwin = new Transaction_Window();

            transwin.Customer = new Person(this.txtFirstName.Text, this.txtLastName.Text, this.txtMiddleName.Text);
            transwin.Customer.Birthday = this.dpBirthday.Text;
            transwin.Customer.Address = this.txtAddress.Text; 
            transwin.Show();

        }
    }
}
