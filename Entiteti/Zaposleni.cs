﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Zaposleni
    {
        public virtual long MBr { get; set; }
        public virtual string Prezime { get; set; } = default!;
        public virtual string Ime { get; set; } = default!;
        public virtual DateTime DatumRodj { get; set; }
        public virtual string? Adresa { get; set; }
        public virtual string? Telefon { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
    }
}
