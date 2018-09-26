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
                case UIMsgText.WinEnemy:
                     winner = enemy._name + "победил!";
                    break;
                case UIMsgText.WinUser:
                    winner = user._name + "победил!";
                    break;
                case UIMsgText.AllDead:
                    winner = "Ничья! Оба героя погибли!";
                    break;
                default:                    
                    winner = "Ошибка: В методе UIMsgText нет запрашиваемой строки!";
                    break;                
            }            
        }


        public static string BodyPartToString(BodyPart body)
        {
            string result;

            switch (body)
            {
                case BodyPart.Head:
                    result = "Голову";
                    break;
                case BodyPart.Chest:
                    result = "Грудь";
                    break;
                case BodyPart.Stomach:
                    result = "Живот";
                    break;
                case BodyPart.Groin:
                    result = "Пояс(пах)";
                    break;
                case BodyPart.Legs:
                    result = "Ноги";
                    break;                    
                default:
                    result = "Ошибка: BodyPartToString не нашел строку!";
                    break;
            }
            
            return result;
        }




    }
}