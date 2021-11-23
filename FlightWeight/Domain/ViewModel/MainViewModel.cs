using FlightWeight.DataAccess.EF;
using FlightWeight.Domain.Abstractions;
using FlightWeight.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightWeight.Domain.ViewModel
{
   public class MainViewModel:BaseViewModel
    {
        IRepository<City> cityRepo;
        public MainViewModel()
        {
            cityRepo = new CityRepository();
            AllCities = cityRepo.GetAll();
        }


        private ObservableCollection<City> allCities;

        public ObservableCollection<City> AllCities
        {
            get { return allCities; }
            set { allCities = value; OnPropertyChanged(); }
        }

    }
}
