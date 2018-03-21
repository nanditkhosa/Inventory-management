using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Domains;
using Biz.Services;

namespace Web.ViewModels
{
    public class StandardIndexViewModel
    {
        public IEnumerable<FacilityViewModel> Facilities { get; set; }

        public IEnumerable<UserViewModel> Users { get; set; }

        public IEnumerable<AssetViewModel> Assets { get; set; }

        public StandardIndexViewModel(IEnumerable<Facility> facility)
        {
            Facilities = facility.Select(x => new FacilityViewModel(x)).Where(x =>x.IsActive == true);
        }

        public StandardIndexViewModel(IEnumerable<User> userList)
        {
            Users = userList.Select(x => new UserViewModel(x)).Where(x => x.IsActive == true);
        }

        public StandardIndexViewModel(IEnumerable<Asset> asset)
        {
            Assets = asset.Select(x => new AssetViewModel(x)).Where(x => x.IsActive == true);
        }

      
    }

}