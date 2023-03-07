using WebApiAutores.DTOs;

namespace WebAPIAutores.DTOs
{
    public class LibroDTOConAutores : LibroDTO
    {
        public List<AutorDTO> Autores { get; set; }
    }
}