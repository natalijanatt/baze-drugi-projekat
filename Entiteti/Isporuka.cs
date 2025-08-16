﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Isporuka
    {
        public virtual long Id { get; set; }
        public virtual Distributer Distributer { get; set; } = default!;
        public virtual ProdajnaJedinica ProdajnaJedinica { get; set; } = default!;
        public virtual DateTime Datum { get; set; }
        public virtual Zaposleni? Magacioner { get; set; }

        public virtual ISet<IsporukaStavka> Stavke { get; set; } = new HashSet<IsporukaStavka>();
    }
}
