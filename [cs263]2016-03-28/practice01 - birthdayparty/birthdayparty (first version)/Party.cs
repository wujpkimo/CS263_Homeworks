﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    public class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        protected decimal CalculateCostOfDecorations()
        {
            return FancyDecorations ?
                (NumberOfPeople * 15.00M) + 50M
                : (NumberOfPeople * 7.50M) + 30M;
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                return CalculateCostOfDecorations()
                    + CostOfFoodPerPerson * NumberOfPeople;
            }
        }
    }
}