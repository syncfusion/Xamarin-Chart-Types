using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class Stack100Column : ContentPage
    {
        public Stack100Column()
        {
            InitializeComponent();
       
            series1.ItemsSource = new ObservableCollection<RangeAreaData>(Database.db4.Table<RangeAreaData>());
            series2.ItemsSource = new ObservableCollection<RangeAreaData1>(Database.db5.Table<RangeAreaData1>());
            series3.ItemsSource = new ObservableCollection<RangeAreaData2>(Database.db5.Table<RangeAreaData2>());
        }
    }
}
