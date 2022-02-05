using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleOperations
{
    /// <summary>
    /// Some entity or DTO or Datacontract
    /// </summary>
    public class Car
    {
        private int carId = 1;
        public Car(int carId)
        {
            this.CarId = carId;
        }

        public int CarId { get => carId; private set { carId = value; } }
    }
}
