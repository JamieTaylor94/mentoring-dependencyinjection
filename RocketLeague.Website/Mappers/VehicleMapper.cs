using System.Collections.Generic;
using System.Linq;
using RocketLeague.Data;
using RocketLeague.Website.ViewModels;

namespace RocketLeague.Website.Mappers
{
    public class VehicleMapper
    {
        public static List<VehicleModel> Map(List<Vehicle> vehicles)
        {
            var mappedVehicle = vehicles.Select(vehicle => new VehicleModel
                {
                    Hitbox = vehicle.Hitbox,
                    Name = vehicle.Name,
                    ReleaseDate = vehicle.ReleaseDate,
                    Description = vehicle.Description,
                    ImageUrl = vehicle.ImageUrl

                })
                .ToList();

            return mappedVehicle;
        }
    }
}