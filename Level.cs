﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Level
    {
        public Level()
        {


        }

        //================================================Pole===================================================================================

        #region Field  Pole
        /// <summary>
        /// Цена уровня
        /// </summary>
        public decimal PriceLevel = 0;
        /// <summary>
        /// лот на уровень
        /// </summary>
        public static decimal LotLevel = 0;
        /// <summary>
        /// Открытый объем на уровне
        /// </summary>
        public decimal Volume = 0;



        #endregion


        //===============================================Metod====================================================================================
        #region Metod

        public static List<Level> CalculateLevels(decimal priceUP, decimal step, int count)
        {

            List<Level> levels = new List<Level>();

            decimal priceLevel = priceUP;

            for (int i = 0; i < count; i++)
            {
                Level level = new Level();

                level.PriceLevel = priceLevel;

                levels.Add(level);

                priceLevel -= step;
            }
            return levels;
        }

        #endregion

    }






}
