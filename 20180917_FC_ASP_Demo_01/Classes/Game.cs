using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    class Game
    {        
        public Game(ref User user, ref Bot enemy)
        {            
            _user = user;
            _enemy = enemy;
        }

               

        public string Winner
        {
            get
            {
              return _winner;
            }            
        }



        public void StepGame(string hit, string block)
        {

            _enemy.stepGameBot();
            _user.stepGameUser(hit, block);

            //_enemy.StepGame(hit, block);
            //_user.StepGame(hit, block); 
            
            int dmgUser = _user.ChoiceRangeDamage();
            int dmgEnemy = _enemy.ChoiceRangeDamage();

            _user.updateHealth(_enemy._lastAttack, dmgEnemy);
            _enemy.updateHealth(_user._lastAttack, dmgUser);

            CheckWinner();
        }



        
        public void CheckWinner()
        {
            // Проверка на выигрыш бота
            if (_user._health == 0 && _enemy._health > 0)
            {
                UI.MsgWinner(UIMsgText.WinEnemy, _user, _enemy, out _winner);               
            }

            // Проверка на выигрыш пользователя
            if (_enemy._health == 0 && _user._health > 0)
            {                
                UI.MsgWinner(UIMsgText.WinUser, _user, _enemy, out _winner);
            }

            // Проверка на ничью
            if (_user._health == 0 && _enemy._health == 0)
            {                
                UI.MsgWinner(UIMsgText.AllDead, _user, _enemy, out _winner);
            }
        }


        private User _user;
        private Bot _enemy;
        private string _winner;
        

    }
}