using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HandleOperations
{
    public class InventoryManager : ManagerBase, IInventoryService
    {
        public void DeleteCar(int carId)
        {
            //This is the place to throw exception and catch from ManageBase
            ExecuteFaultHandledOperation(() =>
            {
                //With factory pattern
                //ICarRepository carRepository = _DataRepositoryFactory.GetDataRepository<ICarRepository>();


                ICarRepository carRepository = new CarRepository();
                
                carRepository.DeleteCar(carId);
            });
        }

        //This is the place to throw exception and catch from ManageBase
        public Car GetCar(int carId)
        {
            return ExecuteFaultHandledOperation(() =>
            {
                //with factory pattern
                //ICarRepository carRepository = _DataRepositoryFactory.GetDataRepository<ICarRepository>();

                ICarRepository carRepository = new CarRepository();

                Car carEntity = carRepository.Get(carId);
                if (carEntity == null)
                {
                    NotFoundException ex = new NotFoundException(string.Format("Car with ID of {0} is not in database", carId));
                    throw new FaultException<NotFoundException>(ex, ex.Message);
                }

                return carEntity;
            });
        }
    }

    interface ICarRepository
    {
        Car Get(int carId);

        void DeleteCar(int carId);
    }

    class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId)
        {
            //Some operation
        }

        public Car Get(int carId)
        {
            return new Car(carId);
        }
    }
}
