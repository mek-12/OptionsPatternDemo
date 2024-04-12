using OptionsPattern.Properties;

namespace OptionsPattern.Models
{
    internal class Car: Vehicle {
        internal Car(VehicleInfo vehicleInfo) : base(vehicleInfo) { }

        public override void SitOnTheArmChair() {
            base.SitOnTheArmChair();
            System.Console.WriteLine("There is no armchair in this car.");
        }
    }
}
