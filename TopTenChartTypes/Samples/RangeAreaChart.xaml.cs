using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class RangeArea : ContentPage
    {
        public RangeArea()
        {
            InitializeComponent();
       
            series1.ItemsSource = new ObservableCollection<RangeAreaData>(Database.db4.Table<RangeAreaData>());
            //series2.ItemsSource = new ObservableCollection<RangeAreaData1>(Database.db5.Table<RangeAreaData1>());
        }
    }
}
