using Microsoft.Extensions.Options;
using OptionsPattern.Models;
using OptionsPattern.Models.Enum;
using OptionsPattern.Properties;

namespace OptionsPattern.Factory
{
    internal class VehicleProvider {
        VehicleInfo vehicleInfo;
        public VehicleProvider(IOptions<VehicleInfo> options) {
            vehicleInfo = options.Value;
        }
        public Vehicle GetVehicle() {
            switch (vehicleInfo.VehicleType)
            {
                case VehicleType.Car:
                    return new Car(vehicleInfo);
                case VehicleType.Plane:
                    return new Plane(vehicleInfo);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
