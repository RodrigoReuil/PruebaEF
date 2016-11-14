﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string Login { get; set; }
        public DateTime fechaUltimoLogin { get; set; }
        public int IntentosInvalidos { get; set; }
        public Perfil perfil { get; set; }
    }
}
