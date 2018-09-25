using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    abstract class PlayerCharacteristics
    {
        public PlayerCharacteristics(int hp, int minAttack, int maxAttack, int level, string name)
        {
            _health = hp;
            _minAttack = minAttack;
            _maxAttack = maxAttack;
            _level = level;
            _name = name;
        }


        public int _health;    
        public int _minAttack; 
        public int _maxAttack; 
        public int _level;     
        public string _name; 
    }
}