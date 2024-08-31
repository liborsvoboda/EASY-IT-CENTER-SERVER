namespace EasyITCenter.DBModel {

    [Keyless]
    public partial class ProviderViewGeneratedToolRatingList {

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        public int? Rating { get; set; }
        public int? CountRating { get; set; }
        public int? TotalCount { get; set; }
    }
}