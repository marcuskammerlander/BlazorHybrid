using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI;

public partial class NativeView : ContentPage
{
    public NativeView()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        //show native alert
        DisplayAlert("Alert", "You have been alerted", "OK");
    }
}