using System.ComponentModel.DataAnnotations;

namespace WareHouse.Models.WareHouseModel
{
    public class WareHouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public int Capacity { get; set; }

        public string Description { get; set; }
    }
}
