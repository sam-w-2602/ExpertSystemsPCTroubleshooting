/* Expert system development practice
 
Application: PC Troubleshooting,
Author: Samuel WIlliams, 30119279,
Date: 07/08/2025,
Description: Simple expert system to help diagnose PC issues.,
,
Developed for purpose of learning and practice in expert system development.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Expert System PC!");
            Console.WriteLine("This system will help you diagnose issues with your PC.");
            Console.WriteLine("Please answer the following questions to the best of your ability.");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Is your PC turning on? this includes any signs of life, not just a display. (yes/no): ");
            string PcTurnsOn = Console.ReadLine().Trim().ToLower();

            if (PcTurnsOn == "yes")
            {
                Console.WriteLine("does it stay on?");
                string PcStaysOn = Console.ReadLine().Trim().ToLower();

                if (PcStaysOn == "no")
                {
                    Console.WriteLine("Your PC is turning on and immediately shutting down. This could be due to overheating or power supply issues. try introduce more airflow or purchase a new power supply");
                    return;
                }

                Console.WriteLine("Does your PC display anything on the monitor? (yes/no): ");
                string Display = Console.ReadLine().Trim().ToLower();

                if (Display == "no")
                {
                    Console.WriteLine("Your PC is turning on but not displaying anything. Please check your cables connections (Power and Display Connection) and try a different monitor if possible. if problem persists, possible GPU failure");
                    return;
                }

                Console.WriteLine("Does your PC boot into the operating system? (yes/no): ");
                string BootsOS = Console.ReadLine().Trim().ToLower();
                if (BootsOS == "no")
                {
                    Console.WriteLine("Your PC is turning on and displaying but not booting into the operating system. This could be due to a corrupted OS or hardware issues. Try booting into safe mode or using recovery options. If these dont work, reinsallation of OS is required");
                    return;
                }
            }
            else if (PcTurnsOn == "no")
            {
                Console.WriteLine("Your PC is not turning on at all. Please check the power supply, power cable, and ensure that the power outlet is working. If the issue persists, it could be a power supply or serious hardware failure.");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer with 'yes' or 'no'.");
                return;
            }

        }//end Main

    }//end class program

}//end namespace ExpertSystemPC