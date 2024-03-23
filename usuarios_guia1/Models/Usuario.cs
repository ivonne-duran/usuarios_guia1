using System.ComponentModel.DataAnnotations;
namespace usuarios_guia1.Models
{
    public class Usuario
    {
        [Key]
        private int id { get; set; }
        private string nombre { get; set; }
        private string password { get; set; }
        private string genero { get; set; }
        private bool bailar { get; set; }
        private bool correr {  get; set; }
        private bool escalar { get; set; }
        private bool peliculas {  get; set; }
        private int curso { get; set; }
    }
}
