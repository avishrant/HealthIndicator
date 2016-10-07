using HealthIndicator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HealthIndicator.Views
{
    public partial class BMIView : ContentPage
    {
        public BMIView()
        {
            InitializeComponent();
            this.BindingContext = new BMIViewModel();
        }

        
    }
    }

