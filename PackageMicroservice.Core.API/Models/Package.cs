using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PackageMicroservice.Core.API.Models
{
    public class Package
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public bool IsInternationalPackage { get; set; }

        // Navigation properties
        public Category Category { get; set; }
        public ICollection<SubPackage> SubPackages { get; set; }
        public ICollection<PackageImage> Images { get; set; }
    }
}
