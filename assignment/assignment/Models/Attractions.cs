namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attractions
    {
        public int CityID { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttractionID { get; set; }

        [StringLength(50)]
        public string AttractionName { get; set; }

        public decimal? Price { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }
    }
}
