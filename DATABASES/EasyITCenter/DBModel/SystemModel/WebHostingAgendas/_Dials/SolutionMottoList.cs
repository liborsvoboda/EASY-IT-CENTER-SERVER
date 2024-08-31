namespace EasyITCenter.DBModel {

    [Table("SolutionMottoList")]
    [Index("SystemName", Name = "IX_MottoList", IsUnique = true)]
    public partial class SolutionMottoList {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string SystemName { get; set; } = null!;

        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("SolutionMottoLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}