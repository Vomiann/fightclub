using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    class User : Player
    {

        public User(int hp, int minAttack, int maxAttack, int currentDmg, int level, string name)
            : base(hp, minAttack, maxAttack, currentDmg, level, name)
        {

        }






        public void stepGameUser(string hit, string block)
        {
            _lastAttack = new Attack();
            _lastAttack.hitSide = Hit(hit);            
            BodyPart[] userBlock = Block(block);       
            _lastAttack.blockSide1 = userBlock[0]; 
            _lastAttack.blockSide2 = userBlock[1]; 
        }





        public BodyPart Hit(string hit)
        {
            switch (hit)
            {
                case "hit_head":
                    return BodyPart.Head;
                case "hit_chest":
                    return BodyPart.Chest;
                case "hit_stomach":
                    return BodyPart.Stomach;
                case "hit_groin":
                    return BodyPart.Groin;
                case "hit_legs":
                    return BodyPart.Legs;
                default:
                    return BodyPart.NoBody;
            }            
        }

                
        public BodyPart[] Block(string block)
        {            
            int numZones = 2; 
            BodyPart[] userSelectedZones = new BodyPart[numZones];
            
            switch (block)
            {
                case "block_head_and_chest":
                    userSelectedZones[0] = BodyPart.Head;
                    userSelectedZones[1] = BodyPart.Chest;
                    return userSelectedZones;
                case "block_chest_and_stomach":
                    userSelectedZones[0] = BodyPart.Chest;
                    userSelectedZones[1] = BodyPart.Stomach;
                    return userSelectedZones;
                case "block_stomach_and_groin":
                    userSelectedZones[0] = BodyPart.Stomach;
                    userSelectedZones[1] = BodyPart.Groin;
                    return userSelectedZones;
                case "block_groin_and_legs":
                    userSelectedZones[0] = BodyPart.Groin;
                    userSelectedZones[1] = BodyPart.Legs;
                    return userSelectedZones;
                case "block_legs_and_head":
                    userSelectedZones[0] = BodyPart.Legs;
                    userSelectedZones[1] = BodyPart.Head;
                    return userSelectedZones;
                default:
                    userSelectedZones[0] = BodyPart.NoBody;
                    userSelectedZones[1] = BodyPart.NoBody;
                    return userSelectedZones;
            }            
        }

    }
}