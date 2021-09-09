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
    public class ChangeItModel : PageModel
    {
        [BindProperty]
        public SuperHeroModel hero { get; set; }
        public SelectList SuperPowers { get; set; }
        public void OnGet(int id)
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


            hero = SuperHeroManager.SuperHeroes.ToList().Where(c => c.Id == id).FirstOrDefault();
        }
        public IActionResult OnPost()
        {
            var oldHero = SuperHeroManager.SuperHeroes.ToList().Where(c => c.Id == hero.Id).First();

            SuperHeroManager.SuperHeroes.Remove(oldHero);
            SuperHeroManager.SuperHeroes.Add(hero);

            return Redirect("/Heroes/CurrentHeroes");
        }
    }
}
