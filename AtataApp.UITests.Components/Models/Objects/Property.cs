using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Models.Objects
{
    public class Property
    {
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string ListingName { get; set; }
        public string Stage { get; set; } = "Draft";
        public string ListingStatus { get; set; }
        public bool PrivateListing { get; set; } = false;
        public string? ListingURL { get; set; }
        public string SellerContact { get; set; }
        public string EstimatedCommission { get; set; }
        public string? ListingExpiration { get; set; }
        public string? LastTransferDate { get; set; }
        public string? LastTransferPrice { get; set; }
        public string? PricingExpectation { get; set; }
        public string? SellerMotivation { get; set; }

        public string PropertyType { get; set; }    // SOME
        public string SquareFeet { get; set; }
        public string? Units { get; set; }
        public string Occupancy { get; set; }
        public string? YearBuilt { get; set; }
        public string? YearRenovated { get; set; }
        public string? CapitalInvested { get; set; }
        public string? BuildingClass { get; set; }
        public string? Building { get; set; }
        public string? Stories { get; set; }
        public string? ParkingRatio { get; set; }
        public string? Acres { get; set; }
        public string? Zoning { get; set; }
        public string? APN { get; set; }
        public string? Tenancy { get; set; }
        public string? LeaseType { get; set; }    // SOME
        public string? OwnershipInterest { get; set; }

        public string AskingPrice { get; set; } = "Unpriced";
        public string? PricePSF { get; set; }
        public string? PriceUnit { get; set; }
        public string? PriceAcre { get; set; }
        public string? WALT { get; set; }
        public string? CapRate { get; set; }
        public string? NOI { get; set; }
        public string? InPlaceCapRate { get; set; }
        public string? InPlaceNOI { get; set; }
        public string? T12CapRate { get; set; }
        public string? T12NOI { get; set; }
        public string? InPlaceRents { get; set; }
        public string? MarketRents { get; set; }
        public string? RentsBelowMarket { get; set; }
        public string? MarkToMarketCapRate { get; set; }
        public string? GRM { get; set; }
        public string? PotentialGRM { get; set; }
        public string? InvestmentPeriod { get; set; }
        public string? UnleveredIRR { get; set; }
        public string? LeveredIRR { get; set; }
        public string? EquityMultiple { get; set; }
        public string? CashOnCash { get; set; }
        public string? ReturnOnCost { get; set; }

        public string? Highlight1 { get; set; }
        public string? Highlight2 { get; set; }
        public string? Highlight3 { get; set; }
        public string? Highlight4 { get; set; }
        public string? Highlight5 { get; set; }
        public string? Highlight6 { get; set; }

        public string? Description { get; set; }

        public string MainListingImage { get; set; }
        public string? ListingPageBannerImage { get; set; }
        public string? ListingPageBannerVideo { get; set; }
        public List<string>? ListingPageSlideshowImages { get; set; }


        public List<string>? OfferingMaterialsAccess { get; set; }
        public List<string>? AutoApprovedContacts { get; set; }


        public List<string>? DealTeam { get; set; }


        public List<string>? ProfileDealSize { get; set; }
        public List<string>? ProfilePropertyType { get; set; }
        public List<string>? ProfileInvestmentStrategy { get; set; }
        public List<string>? ProfileReturnMetrics { get; set; }
        public List<string>? ProfileMarkets { get; set; }


        public Property Generate()
        {
            return new Property()
            {
                //
            };
        }





    }
}
