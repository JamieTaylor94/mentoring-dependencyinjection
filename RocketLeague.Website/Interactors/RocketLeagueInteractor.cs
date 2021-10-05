using RocketLeague.Website.Mappers;
using RocketLeague.Website.ViewModels;

namespace RocketLeague.Website.Interactors
{
    public class RocketLeagueInteractor
    {
        private readonly VehicleService _vehicleService;

        public RocketLeagueInteractor()
        {
            _vehicleService = new VehicleService();
        }

        public RocketLeagueViewModel GetViewModel()
        {
            var vehicles = _vehicleService.GetAllVehicles();
            return new RocketLeagueViewModel
            {
                Vehicles = VehicleMapper.Map(vehicles)
            };
        }
    }
}
