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

namespace Phone_Book_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listDataGrid.ItemsSource = PhoneBook.phoneBookListings;
        }
      

      

        

        private void addNewUser_Click_1(object sender, RoutedEventArgs e)
        {
           
            PhoneBook.phoneBookListings.Add(new PhoneBookListing(lastName.Text, firstName.Text, phoneNumber.Text));
            MessageBox.Show(firstName.Text + " " + lastName.Text + " has been added to the phone book", "Add Contact", MessageBoxButton.OK, MessageBoxImage.Information);
            firstName.Clear();
            lastName.Clear();
            phoneNumber.Clear();
            RefreshDataGrid();
        }

        private void removeSelectedUser_Click_1(object sender, RoutedEventArgs e)
        {
            if (listDataGrid.SelectedItem != null)
            {
                PhoneBook.phoneBookListings.Remove((PhoneBookListing)listDataGrid.SelectedItem);
                RefreshDataGrid();
                MessageBox.Show("This List is  removed","Remove Contact", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a list to remove","Select List",MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void search_Click_1(object sender, RoutedEventArgs e)
        {

            if (searchResults.ItemsSource == null)
            {

                MessageBox.Show("This Name is not Exist", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            searchResults.ItemsSource = PhoneBook.SearchLastName(toSearch.Text);
        }
        private void RefreshDataGrid()
        {
            listDataGrid.ItemsSource = null;

            listDataGrid.ItemsSource = PhoneBook.phoneBookListings.ToList();
        }
      
    }
}
