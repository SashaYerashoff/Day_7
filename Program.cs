
using System;

namespace majasdarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesno;
            int sessijuSkaititajs = 1;
            string userId = "Anonīmais";

            do
            {
                Console.Clear();
                string currentUser = userId;
                Console.WriteLine("Sessija numurs {0}, Lietotājs: {1}", sessijuSkaititajs, currentUser);
                Console.WriteLine("---------------------------------------");
                //if (sessijuSkaititajs == 1) { userId = Lietotajs(HelloUser()); };
                sessijuSkaititajs++;
				//------Viss izpildams kodz zemāk---------

				Faktorials();

                //------Te izpildams kods beidzas---------
                Console.WriteLine("----------------------------------------");
                Console.Write("Vēlies atkartot visu no jauna? (y/n): ");
                yesno = Console.ReadLine();
            }
            while (yesno == "y");
        }
        //-------Šeit sākas funkcijas---------

		static void Faktorials()
		{
			Console.Write("Ievadi kādu ciparu faktoriālam: ");

			int vertiba = 0;
			string ievade = Console.ReadLine();
			int robeza = Convert.ToInt16(ievade);
            
			for (int i = 1; i <= robeza; i++)
            {
				int oldVertiba = vertiba;
				vertiba = vertiba + i;
				Console.WriteLine("{0} = {2} + {1}", vertiba, i, oldVertiba);
            }

			Console.WriteLine("{0}! = {1}", robeza, vertiba);
		}

        static string Lietotajs(string lietotajs)
        {
            string kaslieto;
            kaslieto = lietotajs;
            return kaslieto;
        }
        static string HelloUser() //---Iepazišanas funkcija
        {
            string userID = "Anonīmāis";

            Console.WriteLine("čau! Esmu C# programma. ");
            Console.Write("Vēlies iepazīties? (y/n): ");
            string yesno = Console.ReadLine();

            switch (yesno)
            {
                case "n":
                    Console.WriteLine("Labs ir, saukšu tevi par {0} ;) ", userID);
                    yesno = "n";
                    break;

                case "y":
                    Console.WriteLine("Forši! Kā man tevi saukt? ");
                    userID = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Prieks iepazīties, {0}!", userID);
                    yesno = "y";
                    break;

                default:
                    Console.Write("Runā skaļāk - slikti dzirdu (iepazīties = y, palikt anonīmām = n ): ");
                    yesno = Console.ReadLine();
                    if (yesno == "y")
                    {
                        goto case "y";
                    }
                    else
                    {
                        if (yesno == "n")
                        {
                            goto case "n";
                        }
                        else
                        {
                            goto default;
                        }
                    }
            }
            return userID;
        }

    }//-------class beigas--------------
}