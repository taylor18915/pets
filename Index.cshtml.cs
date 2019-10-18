using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pet_World.Data;

namespace Pet_World.Pages.Do
{                 
    public class IndexModel : PageModel
    {
        private readonly Pet_World.Data.ApplicationDbContext _context;

        public IndexModel(Pet_World.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dogs> Dogs { get;set; }

        public async Task OnGetAsync()
        {
            var dogs = from Do in _context.Dogs select Do;

            if (User.IsInRole("Owner"))
            {
                dogs = dogs.Where(s => s.DName.Contains("Buddy"));
            } else if (User.IsInRole("Manager"))

            {
                dogs = dogs.Where(s => s.DBreed.Contains("carlos"));

            } else if (User.IsInRole("Assistant")) 
            {
                dogs = dogs.Where(s => s.DName.Contains(""));
            }else
            {
                dogs = dogs.Where(s => s.DName.Contains(""));
            }

            Dogs = await dogs.ToListAsync();
        }
}
                
            




        }
    

