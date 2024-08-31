namespace EasyITCenter.DBModel {

    [Table("ProviderGeneratedToolList")]
    [Index("Name", "UserId", Name = "IX_GeneratedToolList")]
    [Index("Name", Name = "IX_GeneratedToolList_1")]
    [Index("UserId", Name = "IX_GeneratedToolList_2")]
    public partial class ProviderGeneratedToolList {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        public int UserId { get; set; }
        public int? Rating { get; set; }
        public bool DescActive { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ProviderGeneratedToolLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}