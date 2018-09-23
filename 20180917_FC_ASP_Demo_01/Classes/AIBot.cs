using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
     class AIBot
    {
        public static Random Rand = new Random();
        public const int START_RND_ATTACK = (int)BodyPart.Head;  // константа атаки

        // метод выбора атаки бота
        public int SelectActionAttackBot()
        {
            return Rand.Next(START_RND_ATTACK, (int)BodyPart.Legs + 1);
        }
        
        
        // метод выбора защиты бота       
        public BodyPart[] SelectActionDefBot()
        {
            // голова и грудь   (1,2)
            // грудь и живот    (2,3)
            // живот и пояс     (3,4)
            // пояс и ноги      (4,5)
            // ноги и голова    (5,1)

            int numZones = 2; // кол-во зон для защиты
            BodyPart[] selectedZones = new BodyPart[numZones];

            int defZone = SelectActionAttackBot();

            // Выбор возможных вариантов зон защиты
            switch (defZone)
            {
                case 1:
                    selectedZones[0] = BodyPart.Head;
                    selectedZones[1] = BodyPart.Chest;
                    break;
                case 2:
                    selectedZones[0] = BodyPart.Chest;
                    selectedZones[1] = BodyPart.Stomach;
                    break;
                case 3:
                    selectedZones[0] = BodyPart.Chest;
                    selectedZones[1] = BodyPart.Groin;
                    break;
                case 4:
                    selectedZones[0] = BodyPart.Groin;
                    selectedZones[1] = BodyPart.Legs;
                    break;
                case 5:
                    selectedZones[0] = BodyPart.Legs;
                    selectedZones[1] = BodyPart.Head;
                    break;
                default:
                    selectedZones[0] = BodyPart.NoBody;
                    selectedZones[1] = BodyPart.NoBody;
                    break;
            }

            return selectedZones;
        }

    }
}