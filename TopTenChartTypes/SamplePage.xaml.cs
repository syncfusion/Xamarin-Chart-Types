using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Sample
{
    public partial class SamplePage : ContentPage
    {
        public SamplePage()
        {
            InitializeComponent();
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((e.SelectedItem as ListModel).Page == "Axis labels customization")
            {
                Navigation.PushAsync(new AxisLabelCustomization());
            }
            else if ((e.SelectedItem as ListModel).Page == "10. Radar Charts")
            {
                Navigation.PushAsync(new RadarChart ());
            }
            else if ((e.SelectedItem as ListModel).Page == "9. Range Area Charts")
            {
                Navigation.PushAsync(new RangeArea());
            }
            else if ((e.SelectedItem as ListModel).Page == "8. Pyramid Charts")
            {
                Navigation.PushAsync(new Pyramid ());
            }
            else if ((e.SelectedItem as ListModel).Page == "7. Stacked Area Charts")
            {
                Navigation.PushAsync(new RangeAreaStacked());
            }
            else if ((e.SelectedItem as ListModel).Page == "6. Stacked Column Charts")
            {
                Navigation.PushAsync(new Stack100Column());
            }
            else if ((e.SelectedItem as ListModel).Page == "5. Multiple Axis")
            {
                Navigation.PushAsync(new MultipleAxes ());
            }
            else if ((e.SelectedItem as ListModel).Page == "4. Candle Charts")
            {
                Navigation.PushAsync(new CandleChart());
            }
            else if ((e.SelectedItem as ListModel).Page == "3. Column Charts")
            {
                Navigation.PushAsync(new DataMarkerLabelCustomization());
            }
            else if ((e.SelectedItem as ListModel).Page == "2. Doughnut Charts")
            {
                Navigation.PushAsync(new DoughnutSeriesCustomization());
            }
            else if ((e.SelectedItem as ListModel).Page == "1. Spline A")
            {
                Navigation.PushAsync(new LegendIcon());
            }
            else if ((e.SelectedItem as ListModel).Page == "1. Spline B")
            {
                Navigation.PushAsync(new TrackBallTemplate());
            }
            else if ((e.SelectedItem as ListModel).Page == "Axis customization")
            {
                Navigation.PushAsync(new AxisCustomization());
            }
            else if ((e.SelectedItem as ListModel).Page == "Datamarker label customization")
            {
                Navigation.PushAsync(new DataMarkerLabelCustomization());
            }
            else if ((e.SelectedItem as ListModel).Page == "Datamarker template")
            {
                Navigation.PushAsync(new DataMarkerTemplate());
            }
            else if ((e.SelectedItem as ListModel).Page == "Doughnut series customization")
            {
                Navigation.PushAsync(new DoughnutSeriesCustomization());
            }
            else if ((e.SelectedItem as ListModel).Page == "Pie series customization")
            {
                Navigation.PushAsync(new PieSeriesCustomization());
            }
            //else if ((e.SelectedItem as ListModel).Page == "Save As Image")
            //{
            //    Navigation.PushAsync(new SaveAsImage());
            //}
            //else if ((e.SelectedItem as ListModel).Page == "Trackball label customization")
            //{
            //    Navigation.PushAsync(new TrackBallLabelCustomization());
            //}
            //else if ((e.SelectedItem as ListModel).Page == "Trackball template")
            //{
            //    Navigation.PushAsync(new TrackBallTemplate());
            //}
            //else if ((e.SelectedItem as ListModel).Page == "Tooltip template")
            //{
            //    Navigation.PushAsync(new TooltipTemplate());
            //}
        }
    }

    public class ListViewModel
    {
        public ObservableCollection<ListModel> ListData { get; set; }
        public ListViewModel()
        {
            ListData = new ObservableCollection<ListModel>();
            ListData.Add(new ListModel() { Page = "10. Radar Charts" });
            ListData.Add(new ListModel() { Page = "9. Range Area Charts" });
            ListData.Add(new ListModel() { Page = "8. Pyramid Charts" });
            ListData.Add(new ListModel() { Page = "7. Stacked Area Charts" });
            ListData.Add(new ListModel() { Page = "6. Stacked Column Charts" });
            ListData.Add(new ListModel() { Page = "5. Multiple Axis" });
            ListData.Add(new ListModel() { Page = "4. Candle Charts" });
            ListData.Add(new ListModel() { Page = "3. Column Charts" });
            ListData.Add(new ListModel() { Page = "2. Doughnut Charts" });
            ListData.Add(new ListModel() { Page = "1. Spline A" });
            ListData.Add(new ListModel() { Page = "1. Spline B" });
            ListData.Add(new ListModel() { Page = "Axis labels customization" });
            ListData.Add(new ListModel() { Page = "Trackball template" });
            ListData.Add(new ListModel() { Page = "Axis customization" });
            ListData.Add(new ListModel() { Page = "Save As Image" });
            ListData.Add(new ListModel() { Page = "Tooltip template" });
            ListData.Add(new ListModel() { Page = "Datamarker template" });
            ListData.Add(new ListModel() { Page = "Trackball label customization" });
            ListData.Add(new ListModel() { Page = "Pie series customization" });
            ListData.Add(new ListModel() { Page = "Doughnut series customization" });
            ListData.Add(new ListModel() { Page = "Datamarker label customization" });
            ListData.Add(new ListModel() { Page = "Candle chart" });
        }
    }

    public class ListModel
    {
        public string Page { get; set; }
    }
}
