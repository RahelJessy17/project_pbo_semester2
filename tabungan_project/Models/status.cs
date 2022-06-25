using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tabungan_project.Models
{
    [Table("status", Schema = "public")]
    public class status
    {
        [Key]
        public int id_status { get; set; }
        public string nama_status { get; set; }
    }
}