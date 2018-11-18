using MyBankingApp_BackEnd_Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankingApp_BackEnd_Library.Repository
{
  public interface IComptesRepository
  {
    // CRUD Façade
    IEnumerable<Compte> FindAll();
    Compte FindById(string id);
    void Update(Compte c);

    void Delete(string id);

    void Create(Compte c);
    
  }
}
