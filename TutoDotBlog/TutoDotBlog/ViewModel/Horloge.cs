using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TutoDotBlog.ViewModel
{
    public class Horloge : INotifyPropertyChanged
    {
        private volatile bool _isRunning;
        public bool IsRunning => _isRunning; //réalise le get de la propriété
        public ICommand StartCommand { get; private set; }
        public ICommand StopCommand { get; private set; }
        public string Heure => DateTime.Now.TimeOfDay.ToString("g");

        public Horloge()
        {
            StartCommand = new Command(Start);
            StopCommand = new Command(Stop);
        }
        public async void Start()
        {
            _isRunning = true;
            while(_isRunning)
            {
                await Task.Delay(500);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Heure"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Heure)); Evite les fautes d'ortographe
            }
        }

        public void Stop()
        {
            _isRunning = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
