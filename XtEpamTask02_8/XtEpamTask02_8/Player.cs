using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    [Serializable]
    internal class Player
    {
        #region Fields and properties
        private double _hP; // health points
        private double _hPLimit = 100.00; // helath limit nt ot break the game
        private double _mP; // mana points
        private double _mPLimit = 100.00; // mana limit
        private double _sP; // stamina points
        private double _sPLimit= 100.00; // stamina limit
        private int _runeCounter;
        public double HP
        {
            get
            {
                return _hP;
            }
            set
            {
                if ((_hP + value) > _hPLimit)
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
                if ((_mP + value) > _mPLimit)
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
                if ((_sP + value) > _sPLimit)
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
                if (value > 0)
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
        public double HPLimit
        {
            get
            {
                return _hPLimit;
            }

            set
            {
                _hPLimit += value; //increasing by level up
                Console.WriteLine("You HP was increased by {0}", value);
            }
        }
        public double MPLimit
        {
            get
            {
                return _mPLimit;
            }

            set
            {
                _mPLimit += value; //increasing by level up
                Console.WriteLine("You MP was increased by {0}", value);
            }
        }
        public double SPLimit
        {
            get
            {
                return _sPLimit;
            }

            set
            {
                _sPLimit += value; //increasing by level up
                Console.WriteLine("You SP was increased by {0}", value);
            }
        }
        #endregion
        #region Methods for player class
        public void LevelUp()
        {
            // HPLimit+ value of stats
            // MPLimit+ value of stats
            // SPLimit+ value of stats
        }
        #endregion

        #region Constructor
        public Player()
        {
            HP = _hPLimit;
            MP = _mPLimit;
            SP = _sPLimit;
            RuneCounter = 0;
        }
        #endregion
    }
}
