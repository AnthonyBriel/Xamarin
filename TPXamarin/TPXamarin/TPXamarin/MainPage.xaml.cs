using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace TPXamarin
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contact> lesContacts;
        public MainPage()
        {
            InitializeComponent();
            lesContacts = new ObservableCollection<Contact>();
            ContactView.ItemsSource = lesContacts;
            ContactView.ItemSelected += ContactView_ItemSelected;
        }

        void AjoutBTClicked(object sender, EventArgs e)
        {
            Contact c = new Contact(nomContact.Text, numeroContact.Text);
            lesContacts.Add(c);
            confirmLabel.Text = String.Format("{0} avec le numéro {0}", nomContact.Text, numeroContact.Text);
        }
        private void ContactView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Alerte", "Vous avez choisi un élément de la liste", "OK");
        }
    }
}
