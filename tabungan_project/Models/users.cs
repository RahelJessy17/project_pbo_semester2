using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace tabungan_project.Models
{
    [Table("users", Schema = "public")]
    public class users
    {
        [Key]
        public int id_user { get; set; }
        public string nama_user { get; set; }
        public string nomor_hp { get; set; }
        public string passwords { get; set; }

        public int id_status { get; set; }

    }
}