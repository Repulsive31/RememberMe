using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelajarYok.View.AddFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Concentration : ContentPage
    {
        private bool isTimerRunning;
        private TimeSpan countdownTime;
        private int timerInterval = 1000; // Timer interval in milliseconds
        public Concentration()
        {
            InitializeComponent();
            isTimerRunning = false;
        }
        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            startButton.IsEnabled = false;

            if (TimeSpan.TryParseExact(timerEntry.Text, @"hh\:mm\:ss", CultureInfo.InvariantCulture, out countdownTime))
            {
                // Start the countdown
                UpdateTimerLabel();
                Device.StartTimer(TimeSpan.FromMilliseconds(timerInterval), TimerTick);
            }
            else
            {
                startButton.IsEnabled = true;
            }
        }

        private bool TimerTick()
        {
            countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1));

            if (countdownTime <= TimeSpan.Zero)
            {
                // Stop the timer when it reaches zero
                // Enable the start button again
                Device.BeginInvokeOnMainThread(() =>
                {
                    startButton.IsEnabled = true;

                    DisplayAlert("The concetration session is over!", "You can now put the timer again.", "Close");
                });
                return false; // Stop the timer
            }

            UpdateTimerLabel();
            return true; // Continue the timer
        }

        private void UpdateTimerLabel()
        {
            string formattedTime = countdownTime.ToString(@"hh\:mm\:ss");
            Device.BeginInvokeOnMainThread(() =>
            {
                timerLabel.Text = formattedTime;
            });
        }
    }
}