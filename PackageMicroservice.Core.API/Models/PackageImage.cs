using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PackageMicroservice.Core.API.Models
{
    public class PackageImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string ImageUrl { get; set; }
        public Package Package { get; set; }
    }

}
