using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M4_NETCOREMVC.CodeFirst.Models
{   
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        [Required]
        [Display(Name ="Futbolista")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "Nro. Camiseta")]
        public int Dorsal { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "Fec.Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "nvarchar(50)")]
        public string EmailPlayer { get; set; }
        public int PositionsId { get; set; }
        public virtual SoccerPosition Positions { get; set; }

        public virtual List<Team> Teams { get; set; }

        public Player()
        {

        }



    }
}
