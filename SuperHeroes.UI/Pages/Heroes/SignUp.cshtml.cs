using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperHeroes.Application;
using SuperHeroes.Data;

namespace SuperHeroes.UI.Pages.Heroes
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public SuperHeroModel SuperHero { get; set; } = new SuperHeroModel();
        public SelectList SuperPowers { get; set; }
        public static int IdCounter { get; set; }
        public void OnGet()
        {
            var list = Enum.GetNames<Powers>().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains('_'))
                {
                    list[i] = list[i].Replace('_', ' ');
                }
            }
            SuperPowers = new SelectList(list);

        }
        public IActionResult OnPost()
        {
            IdCounter++;
            SuperHero.Id = IdCounter;

            int random = new Random().Next(1, 12);

            SuperHero.Image = "/SuperHeroPics/*.jpg".Replace("*", random.ToString());

            SuperHeroManager.SuperHeroes.Add(SuperHero);
            
            return Redirect("/Heroes/CurrentHeroes");
        }
    }
}
