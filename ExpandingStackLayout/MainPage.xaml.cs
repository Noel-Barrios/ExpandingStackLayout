using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpandingStackLayout
{
    public partial class MainPage : ContentPage
    {
        StackLayout layout;
        bool Flag;
        int count;

        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS) Padding = new Thickness(0, 30, 0, 0);
            count = 0;
            Flag = true;



        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            Debug.WriteLine("Handle_clicked was clicked " + count);
            if (Flag == true)
            {
                Flag = false;
                layout = new StackLayout { Padding = new Thickness(0, 30, 0, 0) };
                var btn = new Button { Text = "Change", TextColor = Color.Blue, FontSize = 20 };
                btn.Clicked += Handle_Clicked;
                layout.Children.Add(btn);
                this.Content = layout;
                SwitchingSL = layout;

            }
            else
            {
                Flag = true;
                layout = new StackLayout { Padding = new Thickness(5, 10), };
                var btn = new Button { Text = "Apply", HorizontalOptions=LayoutOptions.Center };
                btn.Clicked += Handle_Clicked;
                var lbl = new Label { Text = "Blah\nBlah\nBlah\nBlah", HorizontalOptions=LayoutOptions.Center, BackgroundColor=Color.FromHex("#FAFAFA") };

                layout.Children.Add(btn);
                layout.Children.Add(lbl);
                this.Content = layout;
                SwitchingSL = layout;

            }
        }


    }
}
