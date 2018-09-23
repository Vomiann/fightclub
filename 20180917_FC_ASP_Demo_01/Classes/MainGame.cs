using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    class MainGame
    {
       
        public static void StartGame(string hit, string block, ref User user, ref Bot enemy ,out string result)
        {                             
            Game myGame = new Game(ref user, ref enemy);            
            myGame.StepGame(hit, block);
            

            result = "result";


        }

        

        



        //User _user;
        //Bot _enemy;
    }
}