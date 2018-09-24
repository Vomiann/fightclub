using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
     class Bot : Player 
    {
        public Bot(int hp, int minAttack, int maxAttack, int level, string name)
           : base(hp, minAttack, maxAttack, level, name)
        {
            _aiBot = new AIBot();
        }


        public void stepGameBot()
        {
            _lastAttack = new Attack();
            _lastAttack.hitSide = Hit();
            BodyPart[] botBlock = Block();
            _lastAttack.blockSide1 = botBlock[0];
            _lastAttack.blockSide2 = botBlock[1];
        }





        public BodyPart Hit()
        {
            return (BodyPart)_aiBot.SelectActionAttackBot();
        }


        public BodyPart[] Block()
        {
            return _aiBot.SelectActionDefBot();
        }



        
        AIBot _aiBot;


    }
}