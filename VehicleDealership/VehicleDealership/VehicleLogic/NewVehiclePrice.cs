using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDealership.VehicleLogic
{
    public class NewVehiclePrice
    {
        const int fullPercentage = 100;
        int carNewValue;
        const int LowMillage = 100000;
        const int LowMillegeAmount = 30000;
        const int MediamMillege = 150000;
        const int MediamMillegeAmount = 5000;
        const int YearLessThen20111 = 50000;
        const int yearBetween2011And2018 = 10000;
        const int YearGraterThen2019 = 30000;
        public int Millage(int Bookvalue, int millage/*, VehicleSpecs vehicleSpecs, ServiceHistory serviceHistory, int year*/)
        {
            if (millage < LowMillage)
            {
                Bookvalue += LowMillegeAmount;
            }
            return Bookvalue;
        }

        public int VehicleSpec(int bookvalue, VehicleSpecs vehicleSpecs)
        {
            if (vehicleSpecs == VehicleSpecs.High)
            {
                bookvalue += (bookvalue / fullPercentage) * (int)VehicleSpecs.High;
            }
            else if (vehicleSpecs == VehicleSpecs.Mediam)
            {
                bookvalue += (bookvalue / fullPercentage) * (int)VehicleSpecs.Mediam;
            }
            return bookvalue;
        }

        public int ServiceHistory()
        {

        }
    }
}
