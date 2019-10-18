using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_World.Data
{
    public class Dogs
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        [Display(Name ="DID")]
        public string DName { get; set; }
        [Display(Name ="DName")]
        public string DBreed { get; set; }
        [ForeignKey("PID")]
        public int PID { get; set; }
    }
}
