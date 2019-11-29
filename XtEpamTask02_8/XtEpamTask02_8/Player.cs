using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    internal class Player
    {
        private double _hP; // health points
        private double _hPLimit; // helath limit nt ot break the game
        private double _mP; // mana points
        private double _mPLimit; // mana limit
        private double _sP; // stamina points
        private double _sPLimit; // stamina limit
        private int _runeCounter;
        public double HP
        {
            get
            {
                return _hP;
            }
            set
            {
                if ( (_hP + value) > _hPLimit)
                {
                    _hP = _hPLimit;
                }
                else
                {
                    _hP += value;
                }

            }
        }
        public double MP
        {
            get
            {
                return _mP;
            }
            set
            {
                if ( (_mP + value) > _mPLimit)
                {
                    _mP = _mPLimit;
                }
                else
                {
                    _mP += value;
                }

            }
        }
        public double SP
        {
            get
            {
                return _sP;
            }
            set
            {
                if ( (_sP + value) > _sPLimit)
                {
                    _sP = _sPLimit;
                }
                else
                {
                    _sP += value;
                }

            }
        }
        public int RuneCounter
        {
            get
            {
                return _runeCounter;
            }
            set
            {
                if ( value>0 )
                {
                    _runeCounter += value;
                    Console.WriteLine("You've found new Rune");
                }
                else
                {
                    _runeCounter += value;
                    Console.WriteLine("You've lost Rune!");
                }
            }
            
        }
    }
}
