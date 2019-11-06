using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using EXAm_UWP.Entity;
using EXAm_UWP.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EXAm_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchContact : Page
    {
        private ContactModel contactModel;
        public SearchContact()
        {
            this.InitializeComponent();
            this.contactModel = new ContactModel();
        }

        private void Search_Contact(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                name = Name.Text,
                phone = Phone.Text,
            };

            contactModel.Insert(contact);
            this.Frame.Navigate(this.GetType());
        }

        private void AddContact(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddContact));
        }
    }
}
