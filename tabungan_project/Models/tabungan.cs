using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tabungan_project.Models
{
    [Table("tabungan", Schema = "public")]
    public class tabungan
    {
        [Key]
        public int id_tabungan { get; set; }
        public DateTime tanggal_mulai { get; set; }
        public DateTime tanggal_berakhir { get; set; }
        public int id_user { get; set; }
    }
}