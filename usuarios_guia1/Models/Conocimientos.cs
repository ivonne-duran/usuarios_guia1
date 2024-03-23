using System.ComponentModel.DataAnnotations;

namespace usuarios_guia1.Models
{
    public class Conocimientos
    {
        [Key]
        private int id {  get; set; }
        private int usuario_id { get; set; }
        private string conocimiento { get; set; }
    }
}
