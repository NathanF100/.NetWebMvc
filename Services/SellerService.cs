using WebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebMvc.Services
{
    public class SellerService
    {
        private readonly WebMvcContext _context;

        public SellerService(WebMvcContext context){
            _context = context;
        }

        public List<Seller> FindAll(){
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj){
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}