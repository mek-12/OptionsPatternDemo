using OptionsPattern.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPattern.Models
{
    internal abstract class Vehicle {
        public VehicleInfo vehicleInfo { get; set; }
        public Vehicle(VehicleInfo vehicleInfo)
        {
            this.vehicleInfo = vehicleInfo;
        }
        public string Name { 
            get { 
                return this.GetType().Name;
            } 
        }

        public string GetInfo()
        {
            return $"Vehicle Type: {vehicleInfo.VehicleType}, Business Class Exist: {vehicleInfo.BusinessClassExist}, Arm Chair Exist: {vehicleInfo.ArmChairExist}";
        }

        public virtual void SitOnTheArmChair() {
            if (vehicleInfo.ArmChairExist) {
                Console.WriteLine("You are sitting on the armchair.");
            }
        }
    }
}
