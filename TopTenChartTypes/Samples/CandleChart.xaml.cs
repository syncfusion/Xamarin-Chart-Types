using System.Collections.ObjectModel;
using Xamarin.Forms;
using System;

namespace Sample
{
    public partial class CandleChart : ContentPage
    {
        public CandleChart()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<FinancialData>(Database.db3.Table<FinancialData>());
           
        }

        public void OnButtonClick(object sender, EventArgs e)
        {

        }
    }
}
