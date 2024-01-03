namespace ÖDEV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Total_Points = 100;
            int right_easy = 0;
            Random rnd = new Random();
            int number_easy = rnd.Next(10);

            while (true)
            {
                Console.WriteLine("Level One.");

                Console.WriteLine("GUESS THE EASY LEVEL NUMBER:");
                byte unumber = byte.Parse(Console.ReadLine());
                right_easy++;

                if (unumber == number_easy)
                {
                    Console.WriteLine("CORRECT NUMBER  CHOOSE. Go to next high level");
                    Console.WriteLine(Total_Points);

                    Random rnd_normal = new Random();
                    int number_normal = rnd.Next(0, 3);
                    for (int i = 0; i < 4; i++)

                    {
                        
                        Console.WriteLine("Level Two");

                        Console.WriteLine("GUESS THE NORMAL LEVEL NUMBER");
                        byte unumber_normal = byte.Parse(Console.ReadLine());

                        if (unumber_normal == number_normal)
                        {
                            Console.WriteLine("CORRECT NUMBER CHOOSE.Go to next high and last level");
                            Console.WriteLine(Total_Points);

                            int right_hard = 0;
                            Random rnd_hard = new Random();
                            int number_hard = rnd_hard.Next(0, 3);

                            do
                            {
                                Console.WriteLine("Level Three");

                                Console.WriteLine("GUESS THE LAST AND MOST HARD NUMBER");
                                int unumber_hard = int.Parse(Console.ReadLine());

                                if (unumber_hard == number_hard)
                                {
                                    Console.WriteLine("CONGRATULATIONS YOU ENDED THİS GAME");
                                    Console.WriteLine(Total_Points);
                                    break;
                                }
                                else if (right_hard > 3)
                                {
                                    Console.Write("YOU DO NOT HAVE ENOUGH RİGHTS");
                                    break;
                                }

                               
                                else
                                {
                                    Console.WriteLine("TRY AGAİN");
                                    int temp = Total_Points;
                                    Total_Points = (temp - 3);
                                }
                            } while (true);
                        }

                        else if (unumber_normal != number_normal)
                        {
                            Console.WriteLine("TRY AGAİN");
                            int temp = Total_Points;
                            Total_Points = (temp - 5);
                        }

                    }


                }
                else if (right_easy > 6)
                {
                    Console.WriteLine("You do not have enough right");
                    break;
                }
                else if (unumber != number_easy)
                {

                    Console.WriteLine("TRY AGAİN");
                    Console.WriteLine("The Number between 0-10");

                    int temp = Total_Points;
                    Total_Points = (temp - 15);
                }
                
               else if (Total_Points<1)
                {
                    Console.WriteLine("YOU ARE SO BAD İN THİS GAME YOU DO NOT HAVE ANY POİNTS");
                }


            }
        }
    }
}
