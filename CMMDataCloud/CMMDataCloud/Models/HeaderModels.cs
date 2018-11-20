using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CMMDataCloud.Models
{
    public class HeaderModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string InspectionPlanName { get; set; }
        public string Operator { get; set; }
        public string MachineName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime Time { get; set; }

        public virtual ICollection<CharacteristicModels> Characteristics { get; set; } = new List<CharacteristicModels>();
        public virtual ICollection<FeaturesModels> Features { get; set; } = new List<FeaturesModels>();
    }
}