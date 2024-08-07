using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.Entities
{
    public class SystemRequirement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OS { get; set; }
        [Required]
        public bool IsMinimum { get; set; }
        [Required]
        public string SystemProcessor { get; set; }
        [Required]
        public byte SystemMemory { get; set; }
        [Required]
        public int Storage { get; set; }
        [Required]
        public string Graphics { get; set; }
        [Required]
        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public virtual Game Game { get; set; }
    }
}
