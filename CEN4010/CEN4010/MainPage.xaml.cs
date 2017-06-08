using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CEN4010
{
    public partial class MainPage : ContentPage
    {
        Thermostat system = new Thermostat();
        public bool tickEvent()
        {
            Temp.Text = system.getTemperature().ToString();
            return true;
        }
        public MainPage()
        {
            InitializeComponent();
            tickEvent();
            Device.StartTimer(TimeSpan.FromSeconds(15), tickEvent);
        }
    }
}
