using Lab_11.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<MedcentreViewModel> MedcentreList { get; set; }

        public MainViewModel(List<Medcentre> medcentre)
        {
            MedcentreList = new ObservableCollection<MedcentreViewModel>(medcentre.Select(b => new MedcentreViewModel(b)));
        }
    }
}
