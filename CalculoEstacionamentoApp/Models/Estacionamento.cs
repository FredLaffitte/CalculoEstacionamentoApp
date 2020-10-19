using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoEstacionamentoApp.Models
{
    public class Estacionamento
    {

        public int taxaInicial { get; set; } = 2;
        public int taxaPrimeiraHora { get; set; } = 3;
        public int taxaHoraAdicional { get; set; } = 4;
        [Required(ErrorMessage = "A hora informada é inválida.")]
        [Display(Name = "Hora de entrada")]
        [RegularExpression("([01]?[0-9]|2[0-3]):[0-5][0-9]", ErrorMessage = "Informe uma hora válida")]
        public string horaEntrada { get; set; }
        [Required(ErrorMessage = "A hora informada é inválida.")]
        [Display(Name = "Hora de saída")]
        [RegularExpression("([01]?[0-9]|2[0-3]):[0-5][0-9]", ErrorMessage = "Informe uma hora válida")]
        public string horaSaida { get; set; }
      
    }
}
