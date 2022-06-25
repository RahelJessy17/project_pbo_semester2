using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tabungan_project.Models
{
    [Table("item", Schema = "public")]
    public class item
    {
        [Key]
        public int id_item { get; set; }
        public string nama_item { get; set; }
        public int harga { get; set; }
        public string id_category { get; set; }
    }
}