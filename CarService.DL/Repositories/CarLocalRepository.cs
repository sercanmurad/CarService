using CarService.DL.Interfaces;
using CarService.DL.LocalDb;
using CarService.Models.Dto;

namespace CarService.DL.Repositories
{
    internal class CarLocalRepository : ICarRepository
    {
        public void AddCar(Car car)
        {
            StaticDb.Cars.Add(car);
        }

        public void DeleteCar(int id)
        {
            StaticDb.Cars.RemoveAll(c => c.Id == id);
        }

        public List<Car> GetAllCars()
        {
            return StaticDb.Cars;
        }

        public Car? GetById(int id)
        {
            return StaticDb.Cars
                .FirstOrDefault(c =>
                    c.Id == id);
        }


        void ICarRepository.DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarRepository.GetAllCars()
        {
            throw new NotImplementedException();
        }

        Car? ICarRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void ICarRepository.UpdateCar(int id, Car car)
        {
            throw new NotImplementedException();
        }

        void ICarRepository.UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
