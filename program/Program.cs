using System;

namespace paradox
{
    class Program
    {
        static void Main(string[] args)
        {

            void ShowResultOfParadox(){
                int countOfWins = 0;
                for (int i = 0; i < 1000; i++){
                    int[] array = {0,0,0};


                    int doorWithGift = new Random().Next(0,3);
                    array[doorWithGift]= 1;

                    int choiseOfPlayer = new Random().Next(0,3);
                    


                    int doorForOpen = array[doorWithGift];
                    


                    while ( doorForOpen == doorWithGift || doorForOpen == choiseOfPlayer )
                    {
                    doorForOpen = new Random().Next(0,3);
                    }

                    array[doorForOpen] = 99;

                    int newChoise = choiseOfPlayer;
                    while (newChoise == choiseOfPlayer || newChoise == doorForOpen) {
                        newChoise = new Random().Next(0,3);
                    }


                    if (newChoise == doorWithGift) countOfWins++;
                    


                 
                }
                Console.WriteLine($"Количество выигрышей составило: {countOfWins}");

            }

            ShowResultOfParadox();
        }
    }
}
