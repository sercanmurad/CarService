using CarService.Models.Dto;

namespace CarService.DL.Interfaces
{
    public interface ICarRepository
    {
        void AddCar(Car car);

        void DeleteCar(int id);

        List<Car> GetAllCars();

        Car? GetById(int id);
        void UpdateCar(int id, Car car);
        void UpdateCar(Car car);
    }
}
