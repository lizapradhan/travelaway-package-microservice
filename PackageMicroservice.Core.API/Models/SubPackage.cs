using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PackageMicroservice.Core.API.Models
{
    public class SubPackage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubPackageId { get; set; }
        public int PackageId { get; set; }
        public string PlaceToVisit { get; set; }
        public string Description { get; set; }
        public int Days { get; set; }
        public int Nights { get; set; }
        public decimal PricePerAdult { get; set; }
        public bool IsAccomodationAvailable { get; set; }

        // Navigation property
        public Package Package { get; set; }
    }
}
