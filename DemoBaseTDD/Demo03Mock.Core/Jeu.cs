using System;
using System.Collections.Generic;
using System.Text;

namespace Demo03Mock.Core
{
    public class Jeu
    {

        private IDe _de;
        private Demo03Mock.Tests.IDe dewin;
        private Demo03Mock.Tests.IDe dewin1;

        public Jeu(IDe de)
        {
            _de = de;
        }

        public Jeu(Demo03Mock.Tests.IDe dewin)
        {
            this.dewin = dewin;
        }

        public Jeu(Demo03Mock.Tests.IDe dewin1)
        {
        }

        public Jeu(Demo03Mock.Tests.IDe dewin1)
        {
            this.dewin1 = dewin1;
        }

        public bool Jouer() // méthode pour jouer au jeu => retourn true si on gagne
        {
            //throw new NotImplementedException();
            // le joueur gagne si le de renvoie 20
            return _de.Lancer() == 20;
        }
    }
}
