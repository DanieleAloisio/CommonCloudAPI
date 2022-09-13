using System.ComponentModel.DataAnnotations;

namespace RepositoryUsers.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserModel
    {
        [Key]
        public string Matricola { get; set; }
        public string Account { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public bool NTAccount { get; set; }
        public string Dominio { get; set; }
        public string Email { get; set; }
    }
}
