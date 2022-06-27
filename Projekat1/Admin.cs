using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Admin : Korisnik
    {
        public Admin(int uid, string korIme, string lozinka) : base(uid, korIme, lozinka)
        {
            IsAdmin = true;
        }

    }
}
