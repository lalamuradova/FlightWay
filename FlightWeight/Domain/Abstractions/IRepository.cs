using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightWeight.Domain.Abstractions
{
   public interface IRepository<T>
    {
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
        ObservableCollection<T> GetAll();
    }
}
