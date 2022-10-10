using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {

        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "No mínimo 3 e no máximo 50 caracteres")]
        public string Tema { get; set; }

        [Range(1, 12000, ErrorMessage ="{0} não pode ser menor que 1 e maior que 120.000")]
        [Display(Name = "Qtd Pessoas")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="Não é uma imagem válida. (GIF,JPG,JPEG)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Phone(ErrorMessage = "O campo {0} está com número inválido.")]

        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "O campo {0} está inválido.")]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Email { get; set; }
        public  int userId { get; set; }
        public UserDto UserDto { get; set; }

        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}
