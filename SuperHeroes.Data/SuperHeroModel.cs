using System;
using System.Collections.Generic;

namespace SuperHeroes.Data
{
    public class SuperHeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public string Image { get; set; }
        public List<string> PowersList { get; set; }
        public Powers Powers { get; set; }
    }
}
