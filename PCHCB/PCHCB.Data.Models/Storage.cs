namespace PCHCB.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Storage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        [Required]
        public StorageType Type { get; set; } // compatibility check with mb

        [Required]
        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }

    public enum StorageType
    {
        HDD = 0,
        SSD = 1,
        NVME = 2
    }
}
