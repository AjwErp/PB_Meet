using System.ComponentModel.DataAnnotations;

namespace AJWManagementPortal.Models
{
    public class UserModel
    {  //This model now unknown ,,this time we no referance---------
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
