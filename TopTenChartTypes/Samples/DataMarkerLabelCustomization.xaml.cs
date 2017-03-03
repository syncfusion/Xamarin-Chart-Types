using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class DataMarkerLabelCustomization : ContentPage
    {
        public DataMarkerLabelCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<CategoryData>(Database.db.Table<CategoryData>());
        }
    }
}
