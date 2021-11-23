using FlightWeight.Domain.Abstractions;
using FlightWeight.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightWeight.DataAccess.EF
{
    public class CityRepository : IRepository<City>
    {
        public void AddData(City data)
        {
            
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAll()
        {
            using (var context = new FlightWeightEntities())
            {
                var cities = new ObservableCollection<City>(context.Cities);
                return cities;
            }
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
