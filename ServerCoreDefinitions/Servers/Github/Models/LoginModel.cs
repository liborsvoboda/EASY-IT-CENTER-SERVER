using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace EasyITCenter.GitServer.Models
{
	public class GithubLoginModel {
		[Required]
		public string Username { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
    }
}
