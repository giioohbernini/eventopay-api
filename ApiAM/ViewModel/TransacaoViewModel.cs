using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAM.ViewModel
{
    public class TransacaoViewModel
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Evento { get; set; }
        public double Valor { get; set; }
        public string NomeEvento { get; set; }
    }
}