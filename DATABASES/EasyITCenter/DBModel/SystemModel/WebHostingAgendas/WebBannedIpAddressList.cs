namespace EasyITCenter.DBModel {

    [Table("WebBannedIpAddressList")]
    [Index("IpAddress", Name = "IX_WebBannedUserList", IsUnique = true)]
    public partial class WebBannedIpAddressList {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string IpAddress { get; set; } = null!;

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("WebBannedIpAddressLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}