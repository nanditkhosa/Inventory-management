﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
﻿using System.ComponentModel.DataAnnotations;
using Core.Domains;

namespace Web.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public int Id { get; set; }


        [MaxLength(200)]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [MaxLength(200)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public IEnumerable<Facility> ListOfAllFacilities { get; set; }
        
        public int? FacilityId { get; set; }

        public UserViewModel(User user)
        {
           Id = user.Id;
           EmailId = user.EmailId;
           IsActive = user.IsActive;
           Password = user.PasswordHash;
           FacilityId = user.FacilityId;
        }

        public UserViewModel()
        {

        }
    }
}