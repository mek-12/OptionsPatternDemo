using OptionsPattern.Factory;
using OptionsPattern.Models;

namespace OptionsPattern
{
    internal class App {
        private Vehicle vehicle {
            get {
                return vehicleProvider.GetVehicle();
            }
        }
        private VehicleProvider vehicleProvider;
        internal App(VehicleProvider vehicleProvider) {
            this.vehicleProvider = vehicleProvider;
        }

        internal void StartTrip() {
            GetInTheVehicle();
            SitOnTheArmChair();
        }

        internal void GetInTheVehicle() {
            Console.WriteLine($"Getting in the {vehicle.Name}");
        }
        
        internal void SitOnTheArmChair() {
            vehicle.SitOnTheArmChair();
        }
    }
}
