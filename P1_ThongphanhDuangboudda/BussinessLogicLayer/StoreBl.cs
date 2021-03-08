using Microsoft.EntityFrameworkCore;
using ModelLayer.Models;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class StoreBl
    {
        private readonly StoreRPTL _storeRPTL;
        public StoreBl(StoreRPTL storeRPTL)
        {
            _storeRPTL = storeRPTL;
        }

        /// <summary>
        /// This Method calls StoreRPTL to get store information from database
        /// </summary>
        /// <param name=""></param>
        public DbSet<Store> getListOfStores()
        {
            return _storeRPTL.GetListOfStore();
        }

    }
}
