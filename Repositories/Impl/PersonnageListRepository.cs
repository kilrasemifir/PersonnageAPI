using PersonnageAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Repositories.Impl
{
    public class PersonnageListRepository : PersonnageRepository
    {
        private List<Personnage> personnages = new List<Personnage>();

        public void Delete(int id)
        {
            this.personnages[id] = null;
        }

        public void Delete(Personnage p)
        {
            this.personnages[p.Id] = null;
        }

        public IEnumerable<Personnage> FindAll()
        {
            return this.personnages.Where(p => p != null);
        }

        public Personnage FindById(int id)
        {
            return this.personnages[id];
        }

        public Personnage Save(Personnage p)
        {
            p.Id = this.personnages.Count();
            this.personnages.Add(p);
            return p;
        }

        public Personnage Update(Personnage p)
        {
            this.personnages[p.Id] = p;
            return p;
        }
    }
}
