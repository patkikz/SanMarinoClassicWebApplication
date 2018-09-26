using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage="Please enter role name")]
        [Display(Name ="RoleName")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
