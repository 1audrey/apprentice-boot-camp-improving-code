﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
   public class GameRunner
    {

        private static bool notAWinner;

        public static void Main(String[] args)
        {
            Game aGame = new Game();

            aGame.Add("Chet");
            aGame.Add("Pat");
            aGame.Add("Sue");

            Random randomNumberGenerator = new Random(Int32.Parse(args[0]));

            do
            {

                aGame.Roll(randomNumberGenerator.Next(5) + 1);

                if (randomNumberGenerator.Next(9) == 7)
                {
                    notAWinner = aGame.WrongAnswer();
                }
                else
                {
                    notAWinner = aGame.WasCorrectlyAnswered();
                }



            } while (notAWinner);

        }
    }
}
