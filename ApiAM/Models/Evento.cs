﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAM.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public double ValorSugerido { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
    }
}