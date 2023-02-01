using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Common
{
    public static class Exceptions
    {
        public const string NotEnoughFuelExceptionMsg = "{0} needs refueling";
        public const string CannotFitFuelAmountExceptionMsg = "Cannot fit {0} fuel in the tank";
        public const string NegativeFuelExceptionMsg = "Fuel must be a positive number";
    }
}
