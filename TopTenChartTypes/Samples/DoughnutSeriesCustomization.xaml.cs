using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
    public partial class DoughnutSeriesCustomization : ContentPage
    {
        public DoughnutSeriesCustomization()
        {
            InitializeComponent();
            var data = new ObservableCollection<ExpenditureData>(Database.db1.Table<ExpenditureData>());
            series1.ItemsSource = data;

            double total = 0;

            for (int i = 0; i < data.Count; i++)
            {
                total += data[i].AmountSpent;
            }
            label.Text = "$" + total.ToString();

            relativeLayout.Children.Add(label, Constraint.RelativeToParent((Parent) => 
            { return (Parent.Width / 2 - label.Width - 15); }), 
            Constraint.RelativeToParent((Parent) => 
            { return (Parent.Height / 2 - label.Height - 10); }));
        }

    }
}
