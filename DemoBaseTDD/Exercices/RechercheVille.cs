using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices
{
    public class RechercheVille
    {
        public List<string> _villes;
        public RechercheVille()
        {
            _villes = new List<string>
            { 
                "Paris","Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney"," New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" 
            };
        }

        public List<string> Search(string mot)
        {
            //throw new NotImplementedException();
            if (mot == null || mot.Length < 2)
                throw new NotFoundException("Recherche trop courte");
            // return new List<string>();

            var result = _villes
            //.Where(v => v.StartsWith(mot)).ToList();
            //.Where(v => v.StartsWith(mot, StringComparison.OrdinalIgnoreCase)).ToList();
            //.Where(v => v.Contains(mot, StringComparison.OrdinalIgnoreCase)).ToList();
            .Where(v => v.Contains(mot, StringComparison.OrdinalIgnoreCase)).ToList();
            return result;

        }


    }
}
