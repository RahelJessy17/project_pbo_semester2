using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tabungan_project.Models
{
    [Table("category", Schema = "public")]
    public class category
    {
        [Key]
        public int id_category { get; set; }
        public string jenis_kebutuhan { get; set; }
    }
}