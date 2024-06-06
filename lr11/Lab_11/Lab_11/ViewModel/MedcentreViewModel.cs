using Lab_11.Command;
using Lab_11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab_11.ViewModel
{
    class MedcentreViewModel : ViewModelBase
    {
        public Medcentre medcentre;
        public MedcentreViewModel(Medcentre medcentre)
        {
            this.medcentre = medcentre;
        }

        #region Fileds
        public string Name
        {
            get { return medcentre.Name; }
            set
            {
                medcentre.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Specialization
        {
            get { return medcentre.Specialization; }
            set
            {
                medcentre.Specialization = value;
                OnPropertyChanged("Specialization");
            }
        }

        public string Category
        {
            get { return medcentre.Category; }
            set
            {
                medcentre.Category = value;
                OnPropertyChanged("Category");
            }
        }

        public string Department
        {
            get { return medcentre.Department; }
            set
            {
                medcentre.Department = value;
                OnPropertyChanged("Department");
            }
        }
        public string Time
        {
            get { return medcentre.time; }
            set
            {
                medcentre.time = value;
                OnPropertyChanged("Time");
            }
        }

        public DateOnly Date
        {
            get { return medcentre.date; }
            set
            {
                medcentre.date = value;
                OnPropertyChanged("Date");
            }
        }

        public bool IsFree
        {
            get { return medcentre.isFree; }
            set
            {
                medcentre.isFree = value;
                OnPropertyChanged("IsFree");
            }
        }

        private Brush _textColor = Brushes.Black;

        public Brush TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                OnPropertyChanged(nameof(TextColor));
            }
        }

        #endregion
        #region command

        public ICommand Booking
        {
            get
            {
                return new MyCommand((obj) =>
                {
                    this.medcentre.isFree = false;
                    TextColor = Brushes.Blue;
                    IsFree = false;
                }, (obj)=> this.medcentre.isFree);
            }
        }

        public ICommand UnBooking
        {
            get
            {
                return new MyCommand((obj) =>
                {
                    this.medcentre.isFree = true;
                    TextColor = Brushes.Black;
                    IsFree = true;
                }, (obj)=>!this.medcentre.isFree);
            }
        }

        #endregion
    }
}
