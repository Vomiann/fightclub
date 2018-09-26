using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20180917_FC_ASP_Demo_01
{
    abstract class Player : PlayerCharacteristics
    {
        public static Random RndAttack = new Random();


        public Player(int hp, int minAttack, int maxAttack, int currentDmgUser, int level, string name)
               : base(hp, minAttack, maxAttack, currentDmgUser, level, name)
        {

        }
                

        public bool BreakDefense
        {
            get
            {
              return _breakDefense;
            }            
        }



        //public abstract BodyPart Hit();   // Метод нанесения удара

        //public abstract BodyPart[] Block(); // Метод выбора всех блоков (2х зон)

        // Метод учета пошаговой последовательности боя
        //public void StepGame()
        //{
        //    _lastAttack = new Attack();        //  создается новый экземпляр для записи последней выбранной атаки           
        //    _lastAttack.hitSide = Hit();       //  записываем выбранную зону удара                                                          
        //    BodyPart[] block = Block();       //  получаем все выбранные блоки  
        //    _lastAttack.blockSide1 = block[0]; //  записываем 1ю выбранную зону блока
        //    _lastAttack.blockSide2 = block[1]; //  записываем 2ю выбранную зону блока  
        //}



        public void updateHealth(Attack otherUserAttack, int dmgEnemy)
        {
            // проверка на прохождение урона
            //bool fOkDemadge = CheckDamage(otherUserAttack);

            //if (fOkDemadge)
            //{
            //    _health -= dmgEnemy;
            //}

            _breakDefense = CheckDamage(otherUserAttack);

            if (_breakDefense)
            {
                _health -= dmgEnemy;
            }
        }

        // метод выбора показателя урона (диапазон атаки)
        public int ChoiceRangeDamage()
        {
            return RndAttack.Next(_minAttack, _maxAttack + 1);
        }

        
        // Метод проверки на прохождение урона по текущему переданному игроку 
        public bool CheckDamage(Attack enemy)
        {
            bool hit = false;

            // 1. Удар в голову                
            if (enemy.hitSide == BodyPart.Head)
            {
                if (!(_lastAttack.blockSide1 == BodyPart.Head && _lastAttack.blockSide2 == BodyPart.Chest ||
                     _lastAttack.blockSide1 == BodyPart.Legs && _lastAttack.blockSide2 == BodyPart.Head))
                {
                    hit = true;
                }
            }

            // 2. Удар в грудь
            if (enemy.hitSide == BodyPart.Chest)
            {
                if (!(_lastAttack.blockSide1 == BodyPart.Head && _lastAttack.blockSide2 == BodyPart.Chest ||
                    _lastAttack.blockSide1 == BodyPart.Chest && _lastAttack.blockSide2 == BodyPart.Stomach))
                {
                    hit = true;
                }
            }

            // 3. Удар в живот
            if (enemy.hitSide == BodyPart.Stomach)
            {
                if (!(_lastAttack.blockSide1 == BodyPart.Chest && _lastAttack.blockSide2 == BodyPart.Stomach ||
                    _lastAttack.blockSide1 == BodyPart.Stomach && _lastAttack.blockSide2 == BodyPart.Groin))
                {
                    hit = true;
                }
            }

            // 4. Удар в пояс (пах)
            if (enemy.hitSide == BodyPart.Groin)
            {
                if (!(_lastAttack.blockSide1 == BodyPart.Groin && _lastAttack.blockSide2 == BodyPart.Legs ||
                      _lastAttack.blockSide1 == BodyPart.Stomach && _lastAttack.blockSide2 == BodyPart.Groin))
                {
                    hit = true;
                }
            }

            // 5. Удар по ногам
            if (enemy.hitSide == BodyPart.Legs)
            {
                if (!(_lastAttack.blockSide1 == BodyPart.Groin && _lastAttack.blockSide2 == BodyPart.Legs ||
                     _lastAttack.blockSide1 == BodyPart.Legs && _lastAttack.blockSide2 == BodyPart.Head))
                {
                    hit = true;
                }
            }

            return hit;
        }
        

        public Attack _lastAttack; // переменная для записи последнего выбранного действия игрока (атака/блок)
        private bool _breakDefense;

        


    }
}