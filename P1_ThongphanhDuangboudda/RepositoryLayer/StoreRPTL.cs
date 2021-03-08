using Microsoft.EntityFrameworkCore;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class StoreRPTL
    {
        protected readonly AppStoreContext _context;

        public StoreRPTL(AppStoreContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This Method returns Table of Store from database
        /// </summary>
        /// <param name=""></param>
        
       public DbSet<Store> GetListOfStore()
        {
            return _context.Stores; ;
        }

    }
}
