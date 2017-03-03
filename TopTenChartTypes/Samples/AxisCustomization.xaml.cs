using Syncfusion.SfChart.XForms;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Sample
{
    public partial class AxisCustomization : ContentPage
    {
        public AxisCustomization()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<DateTimeData>(Database.db2.Table<DateTimeData>()); ;
        }
    }
}
