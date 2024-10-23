namespace EasyITCenter.DBModel {

    /// <summary>
    /// Custom Class For Server Generator Request Monitoring
    /// </summary>
    public class AutoGenRequest {
        public string? Name { get; set; } = null;
        public string? IpAddress { get; set; } = null;

        // public string? Role { get; set; } = null;
    }

    /// <summary>
    /// Custom Class For Check ConnectionString
    /// </summary>
    public class AutoGenConnectionString {
        public string ConnectionString { get; set; }
    }

    /// <summary>
    /// Generator Uploading files for Generators
    /// </summary>
    public class UploadGeneratorFiles {
        public List<UploadFileData> Files { get; set; }
    }

    /// <summary>
    /// Generator File Class structure
    /// </summary>
    public class UploadFileData {
        public string Name { get; set; } = null;
        public string Extension { get; set; }
        public string FileArray { get; set; }
    }

    /// <summary>
    /// Generator Carousel Image Class
    /// </summary>
    public class CarouselImage {
        public string title { get; set; } = null;
        public string href { get; set; }
        public string thumbnail { get; set; }
    }

    /// <summary>
    /// Generator Carousel Video Class
    /// </summary>
    public class CarouselVideo {
        public string title { get; set; } = null;
        public string type { get; set; } = "video/mp4";
        public string href { get; set; }
        public string preload { get; set; } = "auto";
    }
}