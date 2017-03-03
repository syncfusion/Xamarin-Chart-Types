using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample
{
    public class LegendIcon : ContentPage
    {
        ObservableCollection<ChartDataPoint> datas;
        ObservableCollection<ChartDataPoint> datas2;
        StackLayout rootLayout, legendLayout;
        CheckBox checkBox;
        Label label;
        SfChart chart;
        SplineSeries  series;
        SplineSeries series1;
        bool selected = false;
        public LegendIcon()
        {

            rootLayout = new StackLayout();
            rootLayout.BackgroundColor = Color.White;

            chart = new SfChart();
            chart.VerticalOptions = LayoutOptions.FillAndExpand;
            chart.HorizontalOptions = LayoutOptions.FillAndExpand;

            datas = new ObservableCollection<ChartDataPoint>();
            datas.Add(new ChartDataPoint("Jan", 20));
            datas.Add(new ChartDataPoint("Feb", 25));
            datas.Add(new ChartDataPoint("Mar", 20));
            datas.Add(new ChartDataPoint("Apr", 34));
            datas.Add(new ChartDataPoint("May", 25));
            datas.Add(new ChartDataPoint("Apr", 20));


            datas2 = new ObservableCollection<ChartDataPoint>();
            datas2.Add(new ChartDataPoint("Jan", 40));
            datas2.Add(new ChartDataPoint("Feb", 65));
            datas2.Add(new ChartDataPoint("Mar", 30));
            datas2.Add(new ChartDataPoint("Apr", 24));
            datas2.Add(new ChartDataPoint("May", 55));
            datas2.Add(new ChartDataPoint("Apr", 10));

            CategoryAxis xAxis = new CategoryAxis();
            chart.PrimaryAxis = xAxis;

            NumericalAxis yAxis = new NumericalAxis();
            chart.SecondaryAxis = yAxis;

            series = new SplineSeries();
            series.ItemsSource = datas;
            series.Label = "India";
            series.IsVisibleOnLegend = true;
            chart.Series.Add(series);

            series1 = new SplineSeries();
            series1.ItemsSource = datas2;
            series1.Label = "US";
            series1.IsVisibleOnLegend = true;
            chart.Series.Add(series1);

            legendLayout = new StackLayout();
            legendLayout.Orientation = StackOrientation.Horizontal;
            legendLayout.VerticalOptions = LayoutOptions.Center;
            legendLayout.HorizontalOptions = LayoutOptions.Center;
            legendLayout.Padding = new Thickness(10, 0, 0, 0);

            for (int i = 0; i < chart.Series.Count; i++)
            {
                if (chart.Series[i].IsVisibleOnLegend == true)
                {
                    var legendItemContainer = new StackLayout();
                    legendItemContainer.Orientation = StackOrientation.Horizontal;

                    checkBox = new CheckBox();
                    checkBox.HorizontalOptions = LayoutOptions.Center;
                    checkBox.VerticalOptions = LayoutOptions.Center;
                    checkBox.WidthRequest = 30;
                    checkBox.HeightRequest = 30;
                    checkBox.Source = ImageSource.FromFile("check.png");
                    checkBox.Index = i;
                    
                    var tapGestureRecognizer = new TapGestureRecognizer();
                    tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
                    tapGestureRecognizer.NumberOfTapsRequired = 1;
                    checkBox.GestureRecognizers.Add(tapGestureRecognizer);

                    label = new Label();
                    label.HorizontalOptions = LayoutOptions.Center;
                    label.VerticalOptions = LayoutOptions.Center;
                    label.Text = chart.Series[i].Label;
                    label.FontAttributes = FontAttributes.Bold;

                    legendItemContainer.Children.Add(checkBox);
                    legendItemContainer.Children.Add(label);
                    legendLayout.Children.Add(legendItemContainer);
                }
            }

            rootLayout.Children.Add(chart);
            rootLayout.Children.Add(legendLayout);
            Content = rootLayout;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var box = (CheckBox)sender;

            int index = box.Index;

            if (!selected)
            {
                chart.Series[index].IsVisible = false;
                box.Source = "uncheck.png";
                label.Opacity = 0.3;
                selected = true;
            }

            else
            {
                chart.Series[index].IsVisible = true;
                box.Source = "check.png";
                label.Opacity = 1;
                selected = false;
            }
        }
    }

    public class CheckBox : Image
    {
        public int Index { get; set; }

        public CheckBox()
        {

        }
    }
}
