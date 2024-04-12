using OptionsPattern.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPattern.Models
{
    internal class Plane : Vehicle {
        public Plane(VehicleInfo vehicleInfo): base(vehicleInfo){ }

        public override void SitOnTheArmChair() {
            base.SitOnTheArmChair();
            Console.WriteLine("There is no armchair in this plane.");
        }   
    }
}
