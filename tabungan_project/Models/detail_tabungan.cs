using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tabungan_project.Models
{
    [Table("detail_tabungan", Schema = "public")]
    public class detail_tabungan
    {
        [Key]
        public int nomor_seri { get; set; }
        public int quantity { get; set; }
        public int id_tabungan { get; set; }
        public int id_item { get; set; }
    }
}