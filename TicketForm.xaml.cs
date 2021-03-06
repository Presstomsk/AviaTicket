using AviaTickets.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AviaTickets
{
    /// <summary>
    /// Логика взаимодействия для TicketForm.xaml
    /// </summary>
    public partial class TicketForm : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Link { get; set; }

        private string _depCity;
        private string _arrCity;
        private string _transfer;
        private string _time;
        private string _searchingMethod;
        private string _price;
        private string _company;
        private string _pic;
        private RelayCommand _goToLink;

        public uint ShortPrice { get; set; }        

        public string DepCity
        {
            get
            {
                return _depCity;
            }
            set
            {
                _depCity = value;
                OnPropertyChanged(nameof(DepCity));
            }
        }

        public string ArrCity
        {
            get
            {
                return _arrCity;
            }
            set
            {
                _arrCity = value;
                OnPropertyChanged(nameof(ArrCity));
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public string Transfer
        {
            get
            {
                return _transfer;
            }
            set
            {
                _transfer = value;
                OnPropertyChanged(nameof(Transfer));
            }
        }

        public string SearchingMethod
        {
            get
            {
                return _searchingMethod;
            }
            set
            {
                _searchingMethod = value;
                OnPropertyChanged(nameof(SearchingMethod));
            }
        }

        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
                OnPropertyChanged(nameof(Company));
            }
        }

        public string Pic
        {
            get
            {
                return _pic;
            }
            set
            {
                _pic = value;
                OnPropertyChanged(nameof(Pic));
            }
        }

        public RelayCommand GoToLink
        {
            get
            {
                return _goToLink ?? (_goToLink = new RelayCommand(obj => OpenLink()));
            }
        }


        public TicketForm()
        {
            InitializeComponent();
        }

        private void OpenLink()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://www.aviasales.ru{Link}",
                UseShellExecute = true
            });
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
