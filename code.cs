using System;

namespace try2_less3_list
{
    enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    enum Directions { North, East, South, West, Stay };
    



    class Program
    {
        static void Main(string[] args)
        {
            //part1 of homework
            #region DaysofTheWeek
            WeekDays Today = WeekDays.Wednesday;
           
            switch (Today)
            {
                case WeekDays.Monday:
                    Console.WriteLine("It's Monday!.");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine("It's Tuesday!.");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine("It's Wednesday!.");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine("It's Thursday.");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine("It's Friday!.");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("It's Saturday!.");
                    break;
                case WeekDays.Sunday:
                    Console.WriteLine("It's Sunday!.");
                    break;
                default:
                    break;
            }
            #endregion


            //part 2 of homework
            #region Directions
            Directions PLayerDirections = Directions.Stay;


            switch (PLayerDirections)
            {
                case Directions.North:
                    Console.WriteLine("u went north.");
                    break;
                case Directions.East:
                    Console.WriteLine("u went east.");
                    break;
                case Directions.South:
                    Console.WriteLine("u went south.");
                    break;
                case Directions.West:
                    Console.WriteLine("u went west.");
                    break;
                case Directions.Stay:
                    Console.WriteLine("u stood still?.");
                    break;
                default:
                    break;
            }

            switch (PLayerDirections)
            {
                case Directions.North:
                    Console.WriteLine("u fallen into a cave to the north and you're stuck what now?.");
                    break;
                case Directions.East:
                    Console.WriteLine("u found a lighter to the east at somesort of statue.");
                    break;
                case Directions.South:
                    Console.WriteLine("u found a forest to the south it looks dark maby avoid it for now .");
                    break;
                case Directions.West:
                    Console.WriteLine("u see something moving in the bushes u ran back to the center.");
                    break;
                case Directions.Stay:
                    Console.WriteLine("idn what ur expecting but this is not how games are played mate.");
                    break;
                default:
                    break;
            }


            #endregion
        }
    }
}
