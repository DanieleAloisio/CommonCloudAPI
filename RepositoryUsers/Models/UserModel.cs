using System.ComponentModel.DataAnnotations;

namespace RepositoryUsers.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Matricola { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
    }
}
