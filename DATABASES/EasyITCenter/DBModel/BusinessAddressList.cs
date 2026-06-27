using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyITCenter.DBModel
{
    [Table("BusinessAddressList")]
    public partial class BusinessAddressList
    {
        public BusinessAddressList()
        {
            LicSrvLicenseAlgorithmLists = new HashSet<LicSrvLicenseAlgorithmList>();
            LicSrvUsedLicenseLists = new HashSet<LicSrvUsedLicenseList>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string AddressType { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string CompanyName { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Street { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string PostCode { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? BankAccount { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ico { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Dic { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(2048)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [Unicode(false)]
        public string? AccessToken { get; set; }
        public DateTime? Expiration { get; set; }
        public int SolutionUserId { get; set; }
        public int SolutionUserRoleListId { get; set; }
        [Required]
        public bool? Active { get; set; }
        public DateTime TimeStamp { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? SolutionLanguageListName { get; set; }

        public virtual SolutionLanguageList? SolutionLanguageListNameNavigation { get; set; }
        [ForeignKey("SolutionUserId")]
        [InverseProperty("BusinessAddressLists")]
        public virtual SolutionUserList SolutionUser { get; set; } = null!;
        [ForeignKey("SolutionUserRoleListId")]
        [InverseProperty("BusinessAddressLists")]
        public virtual SolutionUserRoleList SolutionUserRoleList { get; set; } = null!;
        [InverseProperty("BussinessAddressList")]
        public virtual ICollection<LicSrvLicenseAlgorithmList> LicSrvLicenseAlgorithmLists { get; set; }
        [InverseProperty("BussinessAddressList")]
        public virtual ICollection<LicSrvUsedLicenseList> LicSrvUsedLicenseLists { get; set; }
    }
}
