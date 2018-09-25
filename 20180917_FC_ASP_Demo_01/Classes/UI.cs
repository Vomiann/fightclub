using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    class UI
    {
        public static void MsgWinner(UIMsgText str, User user, Bot enemy, out string winner)
        {
            switch (str)
            {
                case UIMsgText.NoMsgText:
                     winner = string.Empty;
                    break;
                case UIMsgText.WinEnemy:
                     winner = enemy._name;
                    break;
                case UIMsgText.WinUser:
                    winner = user._name;
                    break;
                case UIMsgText.AllDead:
                    winner = "Ничья! Оба героя погибли!";
                    break;
                default:                    
                    winner = "Ошибка: В UIMsgText не существует соответствующего сообщения!";
                    break;                
            }            
        }




    }
}