using System;
using System.Collections.Generic;
using System.Text;

namespace interface_csharp.Entities {
    class Vehicle {
        public string Modeel {
            get; set;
        }

        public Vehicle(string modeel) {
            Modeel = modeel;
        }

    }
}
