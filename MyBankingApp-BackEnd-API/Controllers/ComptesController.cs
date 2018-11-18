using MyBankingApp_BackEnd_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MyBankingApp_BackEnd_Library.Domain;
using System.Web.Http.Cors;

namespace MyBankingApp_BackEnd_API.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  public class ComptesController : ApiController
  {

    private IComptesRepository repository ;
    public ComptesController(IComptesRepository repository)  // Pour la constructor injection
    {
      this.repository = repository;
    }

    // GET: api/Comptes
    public IEnumerable<Compte> Get()
    {
      return repository.FindAll();
    }

    // GET: api/Comptes/5
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Comptes
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Comptes/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/Comptes/5
    public void Delete(int id)
    {
    }
  }
}
