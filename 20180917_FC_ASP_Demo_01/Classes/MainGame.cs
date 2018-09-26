using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json; // Json
//using System.Runtime.Serialization.Json; // DataContractJsonSerializer

namespace _20180917_FC_ASP_Demo_01
{
    class MainGame : ILogger
    {
       
        public void StartGame(string hit, string block, ref User user, ref Bot enemy, out string jsonResult)
        {                             
            Game myGame = new Game();            
            myGame.StepGame(hit, block, ref user, ref enemy);
            CreateLogMessage(user, enemy);

            jsonResult = CreateJsonStr(user, enemy, myGame.EndFight, myGame.Winner);
        }


        public void CreateLogMessage(User user, Bot enemy)
        {                        
            // проверка на блок или атаку по игроку (пропуск удара)
            if (user.BreakDefense)
            {
                _log = string.Format("{0}: [{1}] пропустил удар в [{2}] на -{3} [{4}]. ", DateTime.Now.ToLocalTime(), user._name, UI.BodyPartToString(enemy._lastAttack.hitSide), enemy._currentDmg, user._health);
                
            }
            else
            {
                _log = string.Format("{0}: [{1}] заблокировал удар в [{2}] [{3}]. ", DateTime.Now.ToLocalTime(), user._name, UI.BodyPartToString(enemy._lastAttack.hitSide), user._health);
                
            }

            // проверка на блок или атаку по врагу
            if (enemy.BreakDefense)
            {
                _log = string.Format("{0}: [{1}] пропустил удар в [{2}] на -{3} [{4}]. ", DateTime.Now.ToLocalTime(), enemy._name, UI.BodyPartToString(user._lastAttack.hitSide), user._currentDmg, enemy._health);
                
            }
            else
            {
                _log = string.Format("{0}: [{1}] заблокировал удар в [{2}] [{3}]. ", DateTime.Now.ToLocalTime(), enemy._name, UI.BodyPartToString(user._lastAttack.hitSide), enemy._health);
                
            }
        }


        public string CreateJsonStr(User user, Bot enemy, bool endFight, string winner)
        {
            _jsonObj = new JsonDataPlayers();
            _jsonObj.hpUser = user._health;
            _jsonObj.hpBot = enemy._health;
            _jsonObj.log = _log;
            _jsonObj.endFight = endFight;
            _jsonObj.winner = winner;

             string result = JsonConvert.SerializeObject(_jsonObj);

            return result;
        }



               
        private string _log;
        private JsonDataPlayers _jsonObj;       
    }
}