﻿using Oneonones.Domain.Entities;
using Oneonones.Service.Contracts;
using System.Threading.Tasks;

namespace Oneonones.Service.Implementations
{
    public class OneononesHistoricalService : IOneononesHistoricalService
    {
        public Task<OneononeHistoricalEntity> Obtain(string leaderEmail, string ledEmail)
        {
            throw new System.NotImplementedException();
        }

        public Task Insert(OneononeHistoricalInputEntity oneononeHistoricalInput)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(OneononeHistoricalInputEntity oneononeHistoricalInput)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string leaderEmail, string ledEmail)
        {
            throw new System.NotImplementedException();
        }
    }
}