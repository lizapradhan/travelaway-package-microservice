namespace PackageMicroservice.Core.API.ViewModels
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsInternationalPackage { get; set; }
        public IEnumerable<string> Images { get; set; }
        public IEnumerable<SubPackage> SubPackages { get; set; }
        public string CategoryName { get; set; }
    }

    public class SubPackage
    {
        public string Description { get; set; }
        public int SubPackageId { get; set; }
        public int Days { get; set; }
        public int Nights { get; set; }
        public decimal PricePerAdult { get; set; }
        public string PlaceToVisit { get; set; }
        public bool IsAccomodationAvailable { get; set; }
    }
}
