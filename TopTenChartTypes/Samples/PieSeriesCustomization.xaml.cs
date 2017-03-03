using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class PieSeriesCustomization : ContentPage
    {
        public PieSeriesCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<ExpenditureData>(Database.db1.Table<ExpenditureData>());
        }
    }
}
