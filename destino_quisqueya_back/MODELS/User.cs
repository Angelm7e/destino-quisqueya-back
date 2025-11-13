using System.ComponentModel.DataAnnotations;

namespace destino_quisqueya_back.MODELS
{
    public class User
    {
        [Key]
        public Guid userId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
