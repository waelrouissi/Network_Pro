using ProfessionalNetwork.Data.Infrastructure;
using ProfessionalNetwork.Domaine.Entities;
using ProfessionalNetwork.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Service
{
    public class JobOfferService : Service<Job_Offer>, IJobOfferService
    {

        private static IDatabaseFactory dbfactory = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbfactory);
        public JobOfferService() : base(ut)
        {

        }

    }
}
