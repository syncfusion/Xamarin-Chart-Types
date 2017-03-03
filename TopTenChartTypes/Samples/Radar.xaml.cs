using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class RadarChart : ContentPage
    {
        public RadarChart()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<RadarData>(Database.db6.Table<RadarData>());
            series2.ItemsSource = new ObservableCollection<RadarData>(Database.db6.Table<RadarData>());
            series3.ItemsSource = new ObservableCollection<RadarData>(Database.db6.Table<RadarData>());
        }
    }
}
