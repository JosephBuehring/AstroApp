using System;

namespace Astrology_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@" 
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
W           \                     ::                     /                   W
W            \              ______________              /    Z O D I A C     W
W             \       _____/ ____________ \_____       /                     W
W              \   __/ _____/     ::     \_____ \__   /       M A T R I X    W
W               __/ __/           ::           \__ \__                       W
W             _/ __/     ,--.     ::   ,----- _   \__ \_  -=[ 10.01.2020 ]=- W
W           _/ _/ \     (    )    ::  (_)    ( )   / \_ \_                   W
W         _/ _/    \    o)  (_    ::      ----'   /    \_ \_    (Europe)     W
W        / _/       \             ::             /       \_ \                W
W       / /          \       ____________       /          \ \               W
W      / / ._._._     \ ____/     ::     \____ /    .___,   \ \              W
W     / /  | | | )    _/          ::          \_     | |     \ \             W
W    / /   | | |/   _/  \         ::         /  \_  _|_|_     \ \            W
W   | |        |  _/     \        ::        /     \_           | |           W
W   | |          /        \       ::       /        \    _   _ | |           W
W  / /   __     /          \   00000000   /          \    \ /   \ \          W
W | | ._(  )_, |            000########000            |    X     | |         W
W | |  ------  |          00##############00          |   (_)    | |         W
W | |          |         0##################0         |          | |         W
W:| |::::::::::|:::::::::0#####-(Meph.)-####0:::::::::|::::::::::| |:::::::::W
W | |          |         0##################0         | _   _    | |         W
W | |    _,_,  |          00##############00          |  \ /     | |         W
W  \ \  | | |   \          /000########000\          /    |     / /          W
W   | | | | |/   \        /    00000000    \        /     |    | |           W
W   | |           \_     /        ::   ..   \     _/    __________           W
W    \ \       __,  \_  /         ::   \\_)  \  _/      \________/           W
W     \ \      ,'|    \_          ::     \\_  _/         |-o o-||            W
W      \ \   o'       / \____     ::     \  `-._          ) j ( |    _       W
W       \ \ '        /       \__________/ `.    `-.__.----||=||  `--'/-,     W
W        \ \_       /             ::        `.        \---|||||-----' /-.    W
W         \_ \_    /      _____   ::     _    `._      ) .: O-:._,|._(   `.  W
W           \_ \_ /      | _,-'   ::  \_/_\___/  `----/  ||   || `|' _\-,  ) W
W             \_ \__      (__)    ::  \_/ \___/   ___|   ||   || _|3=.___,'  W
W               \__ \__           ::           __/ __|   ||   || `-' |       W
W              /   \__ \_____     ::     _____/ __/  |   ||   ||     |       W
W             /       \_____ \__________/ _____/     |   ||   ||     |       W
W            /              \____________/           |   ||   ||     |       W
W           /                     ::                 |   ||   ||     |       W
W          /                      ::                 |   ||   ||     |       W
W         /                       ::                 |   ||   ||     |       W
W        /                        ::                 |   ||   ||     |       W
W       /                         ::                 |   ||   ||     |       W
W      /                          ::                 |   ||   ||     |       W
W     /                       _____________________________   ||     |       W
W    / _______,--------------'%%%%%%%%%%%%%%%%%%%%%%%%%%%%%`--------------.__W
W  ,--'%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%W
W.'%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%W
W%%%%%[ Based on a Tom Breitenfeldt image ]%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%W
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

");
            

            Console.WriteLine("Please enter the month you were born  ");
            Console.WriteLine();
            string month = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the day you were born  ");
            Console.WriteLine();
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string zodiac_sign = " ";

            if (month == "december")


            {

                if (day < 22)
                    zodiac_sign = "Sagittarius";
                else
                    zodiac_sign = "Capricorn";

            }

            else if (month == "January")
            {

                if (day < 22)
                    zodiac_sign = "Capricorn";
                else
                    zodiac_sign = "Aqaurius";
            }

            else if (month == "February")
            {

                if (day < 22)
                    zodiac_sign = "Aquarius";
                else
                    zodiac_sign = "Pisces";
            }

            else if (month == "March")
            {

                if (day < 22)
                    zodiac_sign = "Pisces";
                else
                    zodiac_sign = "Aries";
            }

            else if (month == "April")
            {

                if (day < 22)
                    zodiac_sign = "Aries";
                else
                    zodiac_sign = "Taurus";
            }

            else if (month == "May")
            {

                if (day < 22)
                    zodiac_sign = "Taurus";
                else
                    zodiac_sign = "Gemini";
            }
            else if (month == "June")
            {

                if (day < 22)
                    zodiac_sign = "Gemini";
                else
                    zodiac_sign = "Cancer";
            }

            else if (month == "July")
            {

                if (day < 22)
                    zodiac_sign = "Cancer";
                else
                    zodiac_sign = "Leo";
            }

            else if (month == "August")
            {

                if (day < 22)
                    zodiac_sign = "Leo";
                else
                    zodiac_sign = "Virgo";
            }

            else if (month == "September")
            {

                if (day < 22)
                    zodiac_sign = "Virgo";
                else
                    zodiac_sign = "Libra";
            }

            else if (month == "October")
            {

                if (day < 22)
                    zodiac_sign = "Libra";
                else
                    zodiac_sign = "Scorpio";
            }

            else if (month == "November")
            {

                if (day < 22)
                    zodiac_sign = "Scorpio";
                else
                    zodiac_sign = "Sagittarius";
            }

            Console.WriteLine("Your zodiac sign is " + zodiac_sign); 

        }
}   }

