using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bestelling : ContentPage
    {
        public Bestelling()
        {
            InitializeComponent();
            string request = "http://maps.googleapis.com/maps/api/staticmap?markers=color:red|label:M|5611DE+Kerkstraat+7+eindhoven&markers=color:blue|label:B|5611BH+Gagelstraat+2&size=340x300";
            Maps.Source = request;
        }

        async void BackButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new HomePage(), this);
            await Navigation.PopAsync();
        }

        private void Ophalen_Toggled(object sender, ToggledEventArgs e)
        {
            enOphalen.IsEnabled = swOphalen.IsToggled;
            if (swOphalen.IsToggled) enOphalen.Text = "";
        }

        private void Bezorgen_Toggled(object sender, ToggledEventArgs e)
        {
            enBezorgen.IsEnabled = swBezorgen.IsToggled;
            if (swBezorgen.IsToggled) enBezorgen.Text = "";
        }
    }
}