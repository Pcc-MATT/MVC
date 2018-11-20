using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CMMDataCloud.Models
{
    public class CharacteristicModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Nominal { get; set; }
        public double UppTol { get; set; }
        public double LowTol { get; set; }
        public double Deviation { get; set; }
        public double Exceed { get; set; }
        public DateTime Time { get; set; }

        [ForeignKey("Header")]
        public Guid HeaderId { get; set; }
        public virtual HeaderModels Header { get; set; }
    }
}