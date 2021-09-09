using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroes.Data;

namespace SuperHeroes.UI.Pages.Heroes
{
    public class ChangeHeroModel : PageModel
    {
        [BindProperty]
        public SuperHeroModel HeroToChange { get; set; }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            //HeroToChange = SuperHeroes.Application.SuperHeroManager.SuperHeroes.ToList().Where(c => c.Id == id).FirstOrDefault();

        }
    }
}
