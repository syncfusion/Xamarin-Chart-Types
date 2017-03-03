using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class MultipleAxes : ContentPage
    {
        public MultipleAxes()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<StackedAreaData1>(Database.db5.Table<StackedAreaData1>());
            series2.ItemsSource = new ObservableCollection<StackedAreaData3>(Database.db7.Table<StackedAreaData3>());
        }
    }
}
