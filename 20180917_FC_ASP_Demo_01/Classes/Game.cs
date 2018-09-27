using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    class Game
    {
        //public Game(ref User user, ref Bot enemy)
        //{            
        //    _user = user;
        //    _enemy = enemy;
        //}
       


        public string Winner
        {
            get
            {
              return _winner;
            }            
        }

        public bool EndFight
        {
            get
            {
                return _endFight;
            }
        }

        

        public void StepGame(string hit, string block, ref User user, ref Bot enemy)
        {            
            enemy.stepGameBot();
            user.stepGameUser(hit, block);

            //_enemy.StepGame(hit, block);
            //_user.StepGame(hit, block); 

            //int dmgUser = _user.ChoiceRangeDamage();
            //int dmgEnemy = _enemy.ChoiceRangeDamage();

            //_user.updateHealth(_enemy._lastAttack, dmgEnemy);
            //_enemy.updateHealth(_user._lastAttack, dmgUser);


            user._currentDmg = user.ChoiceRangeDamage();
            enemy._currentDmg = enemy.ChoiceRangeDamage();

            user.updateHealth(enemy._lastAttack, enemy._currentDmg);
            enemy.updateHealth(user._lastAttack, user._currentDmg);

            CheckWinner(ref user, ref enemy);
        }



        
        public void CheckWinner(ref User user, ref Bot enemy)
        {
            _endFight = false;

            // Проверка на выигрыш бота
            if (user._health == 0 && enemy._health > 0)
            {
                UI.MsgWinner(UIMsgText.WinEnemy, user, enemy, out _winner);
                _endFight = true;
            }

            // Проверка на выигрыш пользователя
            if (enemy._health == 0 && user._health > 0)
            {                
                UI.MsgWinner(UIMsgText.WinUser, user, enemy, out _winner);
                _endFight = true;
            }

            // Проверка на ничью
            if (user._health == 0 && enemy._health == 0)
            {                
                UI.MsgWinner(UIMsgText.AllDead, user, enemy, out _winner);
                _endFight = true;
            }
        }


        //private User _user;
        //private Bot _enemy;
        private string _winner;
        private bool _endFight;


        



    }
}