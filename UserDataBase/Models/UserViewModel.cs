using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserDataBaseUI.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Please enter surname")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Please enter age")]
        [Range(1,100)]
        public int Age { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter adress")]
        public string Adress { get; set; }
    }
}
