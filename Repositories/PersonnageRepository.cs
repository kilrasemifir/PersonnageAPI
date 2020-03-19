using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Repositories
{
    using Models;
    public interface PersonnageRepository
    {
        public Personnage Save(Personnage p);
        public IEnumerable<Personnage> FindAll();
        public Personnage FindById(int id);
        public Personnage Update(Personnage p);
        public void Delete(int id);
        public void Delete(Personnage p);
    }
}
