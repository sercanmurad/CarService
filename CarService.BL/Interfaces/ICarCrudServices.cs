using CarService.Models.Dto;

namespace CarService.BL.Interfaces
{
    public interface ICarCrudServices
    {
        void AddCar(Car car);

        void DeleteCar(int id);
        object DeleteCar();
        List<Car> GetAllCars();
    }
    public Car? GetById(int id)
        {
            return _CarLocalRepository GetById(id);
        }
}
