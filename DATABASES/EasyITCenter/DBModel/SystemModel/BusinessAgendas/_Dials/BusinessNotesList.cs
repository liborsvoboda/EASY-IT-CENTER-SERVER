namespace EasyITCenter.DBModel {

    [Table("BusinessNotesList")]
    [Index("Name", Name = "IX_NotesList", IsUnique = true)]
    public partial class BusinessNotesList {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("BusinessNotesLists")]
        public virtual SolutionUserList User { get; set; } = null!;
    }
}