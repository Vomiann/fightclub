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

        //public override BodyPart Hit()
        //{
        //    return (BodyPart)_aiBot.SelectActionAttackBot();
        //}


        //public override BodyPart[] Block()
        //{
        //    return _aiBot.SelectActionDefBot();
        //}



        
        AIBot _aiBot;


    }
}