﻿namespace ConsoleHome
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Position position = new Position();

            number = WriteLine;

            levels = new List<Level>();

            Load();

            number();

            string str = ReadLIne("Введите кол-во уровней: ");

            countLevels = Convert.ToInt32(str);

            str = ReadLIne("Задайте верхнюю цену: ");

            priceUp = decimal.Parse(str);

            str = ReadLIne("Введите шаг уровня: ");

            StepLevel = decimal.Parse(str);

            str = ReadLIne("Введите лот на уровень: ");

            lotLevel = decimal.Parse(str);

            number();

            Save();

            Console.ReadLine();

        }

        //================================================= Fields ======================================

        #region Fields

        static List<Level> levels;

        static decimal priceUp;

        static decimal lotLevel;

        static int countLevels;

        // ==============================================================================================

        static Trade trade = new Trade();

        #endregion

        //================================================= Properties ==================================

        #region Properties

        public static decimal StepLevel
        {
            get
            {
                return stepLevel;
            }

            set
            {
                if (value <= 100)
                {
                    stepLevel = value;

                    levels = Level.Calculatealevels(priceUp, stepLevel, countLevels);
                }
            }
        }

        static decimal stepLevel;

        #endregion


        //================================================= Methods =====================================

        #region Methods

        static void WriteLine()
        {
            Console.WriteLine("Кол-во элементов в списке: " + levels.Count.ToString());

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine(levels[i].PriceLevel);
            }
        }

        static string ReadLIne(string message)
        {
            Console.WriteLine(message);

            return Console.ReadLine();
        }

        static void Save()
        {
            using (StreamWriter writer = new StreamWriter("params.txt", false))
            {
                writer.WriteLine(priceUp.ToString());

                writer.WriteLine(countLevels.ToString());

                writer.WriteLine(stepLevel.ToString());
            }
        }

        static void Load()
        {
            using (StreamReader reader = new StreamReader("params.txt"))
            {
                int index = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    index++;

                    switch (index)
                    {
                        case 1:
                            priceUp = decimal.Parse(line);
                            break;

                        case 2:
                            countLevels = int.Parse(line);
                            break;

                        case 3:
                            StepLevel = decimal.Parse(line);
                            break;
                    }

                    if (line == null)
                    {
                        break;
                    }
                }
            }
        }

        #endregion
        // ==============================================================================================

        delegate void Number();

        static Number number;

    }


}


