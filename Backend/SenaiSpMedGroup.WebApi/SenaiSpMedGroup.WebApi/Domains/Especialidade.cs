﻿using System;
using System.Collections.Generic;

namespace SenaiSpMedGroup.WebApi.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medico = new HashSet<Medico>();
        }

        public int IdEspecialidade { get; set; }
        public string Titulo { get; set; }

        public ICollection<Medico> Medico { get; set; }
    }
}
