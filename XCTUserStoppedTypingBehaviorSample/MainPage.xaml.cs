using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XCTUserStoppedTypingBehaviorSample
{
    public partial class MainPage : ContentPage
    {
        public Command<string> UserStoppedTypingCommand { get; set; }
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            UserStoppedTypingCommand = new Command<string>((value) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    count++;
                    resultText.Text = $"triggered: {count}, value: {value}";
                });
            });

            BindingContext = this;
        }
    }
}
