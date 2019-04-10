using System;
using System.Collections.Generic;

namespace Roulette
{
    public class App
    {
        Random winningNumber = new Random();
        int theWinningNumber;
        RouletteTable table = new RouletteTable();

        public void Run()
        {
            bool test = true;
            while(test)
            {
                table.Table();

                theWinningNumber = winningNumber.Next(1, 39);

                int[] odd, even, red, black, firstTwelve, secondTwelve,
                      thirdTwelve, oneToEighteen, nineteenToThirtysix,
                      firstThird, secondThird, thirdThird;

                WinningOptions(out odd, out even, out red, out black, out firstTwelve,
                               out secondTwelve, out thirdTwelve, out oneToEighteen,
                               out nineteenToThirtysix, out firstThird, out secondThird,
                               out thirdThird);

                IfWin(odd, even, red, black, firstTwelve, secondTwelve, thirdTwelve, oneToEighteen, nineteenToThirtysix, firstThird, secondThird, thirdThird);
                
                Console.WriteLine("Continue?");
                var response = Console.ReadLine();
                Console.WriteLine();
                
                switch (response)
                {
                    case "y":
                        Console.Clear();
                        test = true;
                        break;
                    case "n":
                        test = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        private void IfWin(int[] odd, int[] even, int[] red, int[] black, int[] firstTwelve, int[] secondTwelve, int[] thirdTwelve, int[] oneToEighteen, int[] nineteenToThirtysix, int[] firstThird, int[] secondThird, int[] thirdThird)
        {
            if (theWinningNumber <= 36)
            {
                Console.WriteLine($"Number: {theWinningNumber}");
            }

            ThirdThird(thirdThird);

            SecondThird(secondThird);

            FirstThird(firstThird);

            AlternateWinnings(odd, even, red, black, firstTwelve, secondTwelve, thirdTwelve, oneToEighteen, nineteenToThirtysix);
        }

        private void AlternateWinnings(int[] odd, int[] even, int[] red, int[] black, int[] firstTwelve, int[] secondTwelve, int[] thirdTwelve, int[] oneToEighteen, int[] nineteenToThirtysix)
        {
            if (Array.Exists(nineteenToThirtysix, element => element == theWinningNumber))
            {
                Console.WriteLine("High/Low: High (19 - 36)");
            }
            if (Array.Exists(oneToEighteen, element => element == theWinningNumber))
            {
                Console.WriteLine("High/Low:  Low (1 - 18)");
            }
            if (Array.Exists(thirdTwelve, element => element == theWinningNumber))
            {
                Console.WriteLine("Dozens: 25 - 36");
            }
            if (Array.Exists(secondTwelve, element => element == theWinningNumber))
            {
                Console.WriteLine("Dozens: 13 - 24");
            }
            if (Array.Exists(firstTwelve, element => element == theWinningNumber))
            {
                Console.WriteLine("Dozens:  1 - 12");
            }
            if (Array.Exists(black, element => element == theWinningNumber))
            {
                Console.WriteLine("Color: Black");
            }
            if (Array.Exists(red, element => element == theWinningNumber))
            {
                Console.WriteLine("Color: Red");
            }
            if (Array.Exists(odd, element => element == theWinningNumber))
            {
                Console.WriteLine("Even/Odd: Odd");
            }
            if (Array.Exists(even, element => element == theWinningNumber))
            {
                Console.WriteLine("Even/Odd: Even");
            }
            if (theWinningNumber == 37)
            {
                Console.WriteLine("The ball landed on 0");
            }
            if (theWinningNumber == 38)
            {
                Console.WriteLine("The ball landed on 00");
            }
        }

        private void ThirdThird(int[] thirdThird)
        {
            if (Array.Exists(thirdThird, element => element == theWinningNumber))
            {
                if (Array.Exists(thirdThird, element => element == theWinningNumber))
                {
                    Console.WriteLine($"Street: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber + 2}");
                }
                if (theWinningNumber == 34)
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber + 1}, {theWinningNumber}/{theWinningNumber - 3}");
                }
                else if (theWinningNumber == 1)
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber + 1}, {theWinningNumber}/{theWinningNumber + 3}");
                }
                else
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber - 3}, {theWinningNumber}/{theWinningNumber + 1}, {theWinningNumber}/{theWinningNumber + 3}");
                }
            }
            if (Array.Exists(thirdThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 1)
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber + 3}/{theWinningNumber + 4}");
                }
                else if (theWinningNumber == 34)
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber - 2}/{theWinningNumber - 3}");
                }
                else
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber + 3}/{theWinningNumber + 4}, " +
                                                      $"{theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber - 2}/{theWinningNumber - 3}");
                }
            }
            if (Array.Exists(thirdThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 1)
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber} - {theWinningNumber + 5}");
                }
                else if (theWinningNumber == 34)
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 3} - {theWinningNumber}");
                }
                else
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 3} - {theWinningNumber}, {theWinningNumber} - {theWinningNumber + 5}");
                }
            }
            if (Array.Exists(thirdThird, element => element == theWinningNumber))
            {
                Console.WriteLine("Column: First");
            }
        }

        public void SecondThird(int[] secondThird)
        {
            if (Array.Exists(secondThird, element => element == theWinningNumber))
            {
                Console.WriteLine($"Street: {theWinningNumber - 1}/{theWinningNumber}/{theWinningNumber + 1}");
            }
            if (Array.Exists(secondThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 35)
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber + 1}, {theWinningNumber}/{theWinningNumber - 3}, {theWinningNumber}/{theWinningNumber - 1}");
                }
                else if (theWinningNumber == 2)
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber + 1}, {theWinningNumber}/{theWinningNumber + 3}, {theWinningNumber}/{theWinningNumber - 1}");
                }
                else
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber - 3}, {theWinningNumber}/{theWinningNumber + 1}, " +
                                              $"{theWinningNumber}/{theWinningNumber + 3}, {theWinningNumber}/{theWinningNumber - 1}");
                }
            }
            if (Array.Exists(secondThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 2)
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber + 3}/{theWinningNumber + 4}, " +
                                                      $"{theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber + 2}/{theWinningNumber + 3}");

                }
                else if (theWinningNumber == 35)
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber - 2}/{theWinningNumber - 3}, " +
                                                      $"{theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber - 3}/{theWinningNumber - 4}");
                }
                else
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber + 3}/{theWinningNumber + 4}, " +
                                                      $"{theWinningNumber}/{theWinningNumber + 1}/{theWinningNumber - 2}/{theWinningNumber - 3}, " +
                                                      $"{theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber - 3}/{theWinningNumber - 4}, " +
                                                      $"{theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber + 2}/{theWinningNumber + 3}");
                }
            }
            if (Array.Exists(secondThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 2)
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 1} - {theWinningNumber + 4}");
                }
                else if (theWinningNumber == 35)
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 4} - {theWinningNumber + 1}");
                }
                else
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 4} - {theWinningNumber + 1}, {theWinningNumber - 1} - {theWinningNumber + 4}");
                }
            }
            if (Array.Exists(secondThird, element => element == theWinningNumber))
            {
                Console.WriteLine("Column: Second");
            }
        }

        private void FirstThird(int[] firstThird)
        {
            if (Array.Exists(firstThird, element => element == theWinningNumber))
            {
                Console.WriteLine($"Street: {theWinningNumber - 2}/{theWinningNumber - 1}/{theWinningNumber}");
            }
            if (Array.Exists(firstThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 36)
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber - 1}, {theWinningNumber}/{theWinningNumber - 3}");
                }
                else if (theWinningNumber == 3)
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber - 1}, {theWinningNumber}/{theWinningNumber + 3}");
                }
                else
                {
                    Console.WriteLine($"Splits: {theWinningNumber}/{theWinningNumber - 3}, " +
                                              $"{theWinningNumber}/{theWinningNumber + 3}, {theWinningNumber}/{theWinningNumber - 1}");
                }
            }
            if (Array.Exists(firstThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 3)
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber + 2}/{theWinningNumber + 3}");
                }
                else if (theWinningNumber == 36)
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber - 3}/{theWinningNumber - 4}");
                }
                else
                {
                    Console.WriteLine($"Corners: {theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber + 2}/{theWinningNumber + 3}, " +
                                  $"{theWinningNumber}/{theWinningNumber - 1}/{theWinningNumber - 3}/{theWinningNumber - 4}");
                }
            }
            if (Array.Exists(firstThird, element => element == theWinningNumber))
            {
                if (theWinningNumber == 3)
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 2} - {theWinningNumber + 3}");
                }
                else if (theWinningNumber == 36)
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 5} - {theWinningNumber}");
                }
                else
                {
                    Console.WriteLine($"Six Numbers: {theWinningNumber - 5} - {theWinningNumber}, {theWinningNumber - 2} - {theWinningNumber + 3}");
                }
            }
            if (Array.Exists(firstThird, element => element == theWinningNumber))
            {
                Console.WriteLine("Column: Third");
            }
        }

        private static void WinningOptions(out int[] odd, out int[] even, out int[] red, out int[] black, out int[] firstTwelve, out int[] secondTwelve, out int[] thirdTwelve, out int[] oneToEighteen, out int[] nineteenToThirtysix, out int[] firstThird, out int[] secondThird, out int[] thirdThird)
        {
            odd = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
            even = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
            red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            firstTwelve = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            secondTwelve = new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            thirdTwelve = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            oneToEighteen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            nineteenToThirtysix = new[] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            firstThird = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            secondThird = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            thirdThird = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        }
    }
}