using System;
using System.Collections.Generic;
using Data_Logic;
using Models;

namespace Business_Logic
{
    public class StoreBL
    {
        private Repository _repo;
        public StoreBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public List<Stores> StoreLocations()
        {
            return _repo.StoreLocations();
        }
    }
}
