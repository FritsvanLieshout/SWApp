using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public string Voornaam = "Erik";
        public ObservableCollection<OverzichtView> overzicht { get; set; }
        public HomePage()
        {
            InitializeComponent();
            lbWelcome.Text = "Welkom, " + Voornaam;
            overzicht = new ObservableCollection<OverzichtView>();
            overzicht.Add(new OverzichtView { Int = 1, Locatie = "Eindhoven", Status = "Bezorgen" });
            overzicht.Add(new OverzichtView { Int = 2, Locatie = "Waalre", Status = "Ophalen" });
            overzicht.Add(new OverzichtView { Int = 3, Locatie = "Valkenswaard", Status = "Bezorgen" });
            overzicht.Add(new OverzichtView { Int = 4, Locatie = "Valkenswaard", Status = "Bezorgen" });
            overzicht.Add(new OverzichtView { Int = 5, Locatie = "Eersel", Status = "Bezorgen" });
            overzicht.Add(new OverzichtView { Int = 6, Locatie = "Tilburg", Status = "Ophalen" });
            overzicht.Add(new OverzichtView { Int = 7, Locatie = "Den Bosch", Status = "Bezorgen" });
            overzicht.Add(new OverzichtView { Int = 8, Locatie = "Oss", Status = "Ophalen" });
            overzicht.Add(new OverzichtView { Int = 9, Locatie = "Ledeacker", Status = "Bezorgen" });
            overzicht.Add(new OverzichtView { Int = 10, Locatie = "Son en Breugel", Status = "Ophalen" });
            overzicht.Add(new OverzichtView { Int = 11, Locatie = "Eindhoven", Status = "Ophalen" });
            overzicht.Add(new OverzichtView { Int = 12, Locatie = "Eindhoven", Status = "Bezorgen" });
            lvOverzicht.ItemsSource = overzicht;
        }
        
        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new MainPage(), this);
            await Navigation.PopAsync();
        }

        async void TappedItem(object sender, ItemTappedEventArgs e)
        {
            lvOverzicht.SelectedItem = BackgroundColor.Equals(Color.LightGreen);
            Navigation.InsertPageBefore(new Bestelling(), this);
            await Navigation.PopAsync();
        }
    }
}