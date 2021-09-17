using System.ComponentModel.DataAnnotations;

namespace Auth.Models
{
  public enum Role
  {
      Admin,
      User,
  }

  public class User
  {
      [Key]
      public int UserId { get; set; }
      public string Login { get; set; }
      public string Password { get; set; }
      public Role Role { get; set; }
  }
}