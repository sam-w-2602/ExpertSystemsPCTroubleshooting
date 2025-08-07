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
                Console.WriteLine("Does the pc have power to the power supply (is it pluged in/ does the wall socket work)");
                string PowerToPC = Console.ReadLine().Trim().ToLower();
                if (PowerToPC == "yes")
                {
                    Console.WriteLine("is the front IO header plugged in? (refer to motherboard manual)");
                    string FrontIOHeader = Console.ReadLine().Trim().ToLower();
                    if (FrontIOHeader == "yes")
                    {
                        Console.WriteLine("unplug it and short power button pins with a screw driver.");
                        Console.WriteLine("Did the pc turn on?");
                        string ShortingConnectorPinWork = Console.ReadLine().Trim().ToLower();
                        if (ShortingConnectorPinWork == "yes")
                        {
                            Console.WriteLine("The front IO header is faulty. Replace it or get a new PC Case");
                        }
                        else if (ShortingConnectorPinWork == "no")
                        {
                            Console.WriteLine("The motherboard is likely faulty. Consider replacing it.");
                        }
                    }
                    else if (FrontIOHeader == "no")
                    {
                        Console.WriteLine("Please plug in the front IO header to the motherboard. This is essential for the power button to function.");
                        return;
                    }

                }
                if (PowerToPC == "no")
                {
                    Console.WriteLine("Please check the power supply and wall socket. Ensure the power supply is plugged in and the wall socket is working. If the problem persists, consider replacing the power supply.");
                    return;
                }
            }

            else
            {
                Console.WriteLine("Invalid input. Please answer with 'yes' or 'no'.");
                return;
            }

        }//end Main

    }//end class program

}//end namespace ExpertSystemPC