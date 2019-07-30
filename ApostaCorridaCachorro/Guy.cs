﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaCorridaCachorro
{
    class Guy
    {
        public string Name;     //Nome da pessoa
        public Bet MyBet;       //Instância de Bet que tem a aposta
        public int Cash;        //Quantia que a pessoa tem

        //Variaveis para controle de formulário da GUI
        public RadioButton MyRadioButton;   //RadioButton da pessoa
        public Label MyLabel;               //Label da pessoa

        public void UpdateLabels()
        {
        }

        public void ClearBet(){ MyBet.Amount = 0; }

        public bool PlaceBet(int Amount, int Dog)
        {
            if(Amount >= 5)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                MyBet.Bettor = this;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}