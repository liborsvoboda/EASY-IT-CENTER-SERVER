namespace EasyITCenter.DBModel {

    [Table("BasicCalendarList")]
    public partial class BasicCalendarList {

        [Key]
        public int UserId { get; set; }

        [Key]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [StringLength(1024)]
        [Unicode(false)]
        public string? Notes { get; set; }

        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("BasicCalendarLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}