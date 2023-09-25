using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPFDashboard.Core;
using WPFDashboard.MVVM.View;

namespace WPFDashboard.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVM { get; set; }
        public MoreViewModel MoreVM { get; set; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MoreViewCommand { get; set; }



        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            MoreVM = new MoreViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            MoreViewCommand = new RelayCommand(o =>
            {
                CurrentView = MoreVM;
            });
        }
    }
}
