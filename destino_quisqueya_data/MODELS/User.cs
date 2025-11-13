using System.ComponentModel.DataAnnotations;

namespace destino_quisqueya_back.MODELS
{
    public class User
    {
        [Key]
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
