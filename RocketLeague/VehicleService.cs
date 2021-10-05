using System.Collections.Generic;
using RocketLeague.Data;

namespace RocketLeague
{
    public class VehicleService
    {
        private readonly VehicleRepository _vehicleRepository;
        
        public VehicleService()
        {
            _vehicleRepository = new VehicleRepository();
        }

        public List<Vehicle> GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetVehicles();
            return vehicles;
        }
    }
}
