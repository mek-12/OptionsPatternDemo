using OptionsPattern.Models;
using OptionsPattern.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPattern.Properties {
    public class VehicleInfo {
        public VehicleType? VehicleType { get; set; }
        public bool BusinessClassExist { get; set; }
        public bool ArmChairExist { get; set; }
    }
}
