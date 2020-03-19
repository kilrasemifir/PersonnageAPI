using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Services
{
    using Models;
    public interface PersonnageService
    {
        public IEnumerable<Personnage> TrouverTous();
        public Personnage TrouverUn(int id);
        public Personnage Modifier(Personnage p);
        public Personnage Sauvegarde(Personnage p);
        public void Supprimer(int id);
    }
}
