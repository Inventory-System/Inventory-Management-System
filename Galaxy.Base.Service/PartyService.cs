using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain.ServiceInterface;

namespace Galaxy.Base.Service
{
    public class PartyService:Service<Party>,IPartyService
    {
        public PartyService(IRepository<Party> repository) : base(repository)
        {
        }
    }
}
