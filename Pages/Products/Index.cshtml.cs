using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using exam2try.Data;
using exam2try.Models;

namespace exam2try.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly exam2try.Data.ApplicationDbContext _context;

        public IndexModel(exam2try.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
