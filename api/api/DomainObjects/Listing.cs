using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.DomainObjects
{
    //todo: why using getter/setter or not
    public class Listing
    {
        // Location
        public Address Address;             // Level 1
        public string Area;
        public string SubArea;

        // MLS
        public string ListNumber;
        public int Status;
        public DateTime ListDate;
        public DateTime SoldDate;
        public int DaysOnMarket;
        public string TitleToLand;
        public string SellersInterest;

        // Prices
        public decimal ListPrice;           // Level 1
        public decimal PreviousPrice;
        public decimal OriginalPrice;
        public decimal SoldPrice;

        // Lot
        public decimal LotSize;             // Level 1
        public decimal Frontage;
        public decimal Depth;
        public string View;
        public string Zoning;

        // Property
        public string DwellingType;
        public int YearBuilt;
        public int Age;                     // Level 1
        public decimal GrossTaxes;
        public string StyleOfHome;
        public string Construction;
        public string Exterior;
        public string Foundation;
        public string Renovations;
        public int RenovationYear;
        public string Heating;
        public string TypeOfRoof;
        public int NumberOfFireplaces;
        public string FireplaceFuel;
        public int NumberOfParking;
        public int NumberOfCoveredParking;
        public string Features;
        public string PublicRemarks;

        // Rooms
        public Room[] Bedrooms;
        public int NumberOfBedrooms;        // Level 1
        public Bathroom[] Bathrooms;
        public int NumberOfBathrooms;
        public int NumberOfFullBaths;
        public int NumberOfHalfBaths;
        public int NumberOfKitchens;
        public decimal FinishedMain;
        public decimal FinishedAbove;
        public decimal FinishedBelow;
        public decimal FinishedBasement;
        public decimal FinishedTotal;       // Level 1
        public decimal UnfinishedFloor;
        public decimal GrandTotal;
        public string[] Pictures;

        // Realtor
        public string ListBroker1;
        public string ListRealtor1;
        public string ListBroker2;
        public string ListRealtor2;
        public string Owner;
        public string Commission;
        public string AppointmentMethod;
        public string Contact;
        public string Phone;
        public string Occupany;
        public string ReatorRemarks;
    }
}