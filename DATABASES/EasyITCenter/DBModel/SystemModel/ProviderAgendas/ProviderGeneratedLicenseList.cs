namespace EasyITCenter.DBModel {

    [Table("ProviderGeneratedLicenseList")]
    [Index("PartNumber", Name = "IX_ProviderGeneratedLicenseList", IsUnique = true)]
    public partial class ProviderGeneratedLicenseList {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string PartNumber { get; set; } = null!;

        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; } = null!;

        public DateTime Expiration { get; set; }

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ProviderGeneratedLicenseLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}