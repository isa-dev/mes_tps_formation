using System;
using System.Collections.Generic;
using System.Text;
using static Exercices.Exo4.Roll;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercices.Exo4
{
    public class Frame
    {
        private int _score;
        private bool _lastFrame;
        private IGenerateur _generateur;
        private List<Roll> _rolls = new();

        public Frame(IGenerateur generateur, bool lastFrame)
        {
            _lastFrame = lastFrame;
            _generateur = generateur;
        }

        public Frame(IGenerateur generateur)
        {
            _generateur = generateur;
        }

        public int Score => _score;
    public bool MakeRoll()
        {
            //throw new NotImplementedException();
            if (!CanRoll())
                return false;

            int max = GetMaxPinsForNextRoll();
            int pins = _generateur.RandomPin(max);

            _rolls.Add(new Roll(pins));
            _score += pins;
            return true;


        }

        private bool CanRoll()
        {

            // Frame normale : max 2 lancers, strike bloque le 2e
            if (!_lastFrame)
            {
                if (_rolls.Count == 0) return true;
                if (_rolls.Count == 1) return _rolls[0].Pins != 10;
                return false;
            }
            //max 3 lancer pour dernière
            if (_rolls.Count == 0) return true;
            if (_rolls.Count == 1) return true;

            return false;
        }


        private int GetMaxPinsForNextRoll()
        {
            //throw new NotImplementedException();
            if (_rolls.Count == 0) return 10; // 1er lancer

            if (!_lastFrame) //2eme lancer
                return 10 - _rolls[0].Pins;

            // si strike au 1er --> 10


            //3eme lancer
            return 10;
            
        }

        
    }
}
