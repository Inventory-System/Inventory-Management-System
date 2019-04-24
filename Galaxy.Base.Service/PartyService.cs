using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;

namespace Galaxy.Base.Service
{
    class PartyService:Service<Party>
    {
        public PartyService(IRepository<Party> repository) : base(repository)
        {
        }
    }
}
