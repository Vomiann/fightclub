﻿using System;
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

        public void updateHealth(Attack otherUserAttack, int dmgEnemy)
        {           
            _breakDefense = CheckDamage(otherUserAttack);

            int currentHP = _health;

            if (_breakDefense)
            {
                if ( !((currentHP -= dmgEnemy) < 0) )
                {
                  _health -= dmgEnemy;                   
                }
                else
                {
                    _health = 0;
                }
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