using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Password_Gen_3k
{
    /// <summary>
    /// varibles in here
    /// </summary>
    class Vr
    {
        public static Random rn = new Random();
        public static short cmd_g = 0;
        public static char[] lc_lst = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static char[] smbl_lst = new char[] {'!','"','£','$','%','^','&','*','(',')','\\','|',',','<','.','>','[',']','{','}','_','-','+','=',':',';','@','\'','#','~'};
        public static string pwd = "";
        public static bool run = true;
        public static double lstp = 0;
    }
    /// <summary>
    /// Main is the starting function and the menu is in here.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is quick
        /// </summary>
        /// <param name="args">length and type</param>
        static void Main(string[] args)
        {
            //checks for Arguments
            if ((args == null)||(args.Length >= 0))
            {
                //quick loading bar to look cool
                for (short i = 0; i <= 10; i++)
                {
                    Console.Clear();
                    Console.Write("Loading...\n");
                    Fn.Pbar((double)i / 10, false);
                    Console.Write("\nGenorating a couple Duocentillion (10^309) possible passwords.");
                    Thread.Sleep(Fn.Ran(1, 100));
                }
                Menu();
            }
            else
            {
                Fn.Msg("Arguments are no yet supported on startup.","Args error!");
            }
        }
        static void Menu()
        {
            //clears screen
            Console.Clear();
            //Shows menu
            Console.Write("=====< Password Genorator 3072 >=====\nWelcome to Password Gen 3072 (C#.net ver)\nTo create a password choose an option:\n0 - BasicPassword\n1 - Custome varibles\n9 - Exit\n>");
            //Input
            string ask = Console.ReadLine();
            //checks
            if (Fn.Ccmd(ask,0,65))
            {
                Vr.cmd_g = Convert.ToInt16(ask);
                if (Vr.cmd_g == 0)
                {
                    ask = Console.ReadLine();
                    if (Fn.Ccmd(ask, 1, long.MaxValue))
                    {
                        long len = Convert.ToInt64(ask);
                        string pwd = "";
                        Vr.pwd = pwd = Pwg.Pass1(len, new bool[] { true, true, true });
                        Console.Clear();
                        Console.WriteLine("Your new password is:\n" + pwd);
                        Console.ReadLine();
                    }


                }
            }

            if (Vr.run)
                Menu();
        }
    }
    /// <summary>
    /// the genorator of the password 
    /// </summary>
    class Pwg
    {
        /// <summary>
        /// Genorates password (many args)
        /// </summary>
        /// <param name="length">length of password</param>
        /// <param name="other">0 - caps, 1 - numbers, 2 - symbols</param>
        public static string Pass1(long length, bool[] other)
        {
            try
            {
                string pwd = "";
                
                for  (long i = 0;i <= length;i++)
                {
                    short r_i = (short)Fn.Ran(0, 3);
                    if (r_i == 0)
                    {
                        pwd += Vr.lc_lst[Fn.Ran(0, Vr.lc_lst.Length - 1)].ToString();
                    }
                    else if ((r_i == 1)&&(other[0]))
                    {
                        pwd += Vr.lc_lst[Fn.Ran(0, Vr.lc_lst.Length - 1)].ToString().ToUpper();
                    }
                    else if ((r_i == 1) && (other[1]))
                    {
                        pwd += Fn.Ran(0, 9);
                    }
                    else if ((r_i == 1) && (other[2]))
                    {
                        pwd += Vr.smbl_lst[Fn.Ran(0, Vr.smbl_lst.Length - 1)].ToString();
                    }
                    
                    Fn.Pbar((double)i / length, true);
                    //Console.Write("Making password - "+(Math.Round((double)(i/length) * 200) / 2).ToString());
                }
                return pwd;
            }
            catch (Exception)
            {
                
                return null;
            }
        }
    }
    /// <summary>
    /// other functions
    /// </summary>
    class Fn
    {
        /// <summary>
        /// Progress bar (many args) - This progress bar is used to show progress
        /// </summary>
        /// <param name="length">The length of the bar</param>
        /// <param name="fraction">The fraction of the bar that is done</param>
        /// <param name="symbols">0 - start, 1 - empty, 2 - filled, 3 - end</param>
        public static void Pbar(short length, double fraction, string[] symbols, bool clear)
        {
            //!= (round(pf*200)/2)):
            //System.Windows.Forms.MessageBox.Show((Vr.lstp != Math.Round(fraction * 100, 1)).ToString());
            //System.Windows.Forms.MessageBox.Show(Vr.lstp.ToString());
            //System.Windows.Forms.MessageBox.Show(Math.Round(fraction*100,1).ToString());

            if (Vr.lstp != Math.Round(fraction *100,1))
            {
                
                Vr.lstp = Math.Round(fraction * 100, 1);
                
                if (clear)
                    Console.Clear();
                
                string middle = "";
                //middle = (symbols[2] * (int)(Math.Round(length * fraction,0))) + (symbols[1] * int(1 - length * fraction));
                for (short i = 0; i <= length; i++)
                {
                    if ((int)(length * fraction) >= i + 1)
                    {
                        middle += symbols[2];
                    }
                    else
                    {
                        middle += symbols[1];
                    }
                }
                //System.Windows.Forms.MessageBox.Show(middle);
                
                Console.Write(symbols[0] + middle + symbols[3] + "\n"+(Math.Round(fraction * 100, 1)).ToString()+"%\n");
            }
        }
        /// <summary>
        /// Progress bar (simple) - This is quicker
        /// </summary>
        /// <param name="fraction">Faction to be covered</param>
        /// <param name="clear">If clear</param>
        public static void Pbar(double fraction, bool clear)
        {
            Fn.Pbar(100, fraction, new string[] { "[", "-", "=", "]" }, clear);
        }
        public static int Ran(int from, int to)
        {
            
            int rnn = Vr.rn.Next(from, to);
            return rnn;
        }
        public static void Msg(string title, string message)
        {
            //beeps
            Console.Beep();
            //saves old colour
            ConsoleColor old1 = Console.BackgroundColor;
            ConsoleColor old2 = Console.ForegroundColor;
            //changes colour
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            //sets screen colour
            Console.Clear();
            //title in red
            Console.WriteLine("-----< Error: "+title+" >-----");
            //text colour change
            Console.ForegroundColor = ConsoleColor.Black;
            //message in black
            Console.Write(message+"\n\nPress Enter to continue\n>");
            Console.ReadLine();
            //sets things back to normal
            Console.BackgroundColor = old1;
            Console.ForegroundColor = old2;

        }
        /// <summary>
        /// Check comand
        /// </summary>
        /// <param name="ask"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Ccmd(string ask, long min, long max)
        {
            try
            {
                if ((min <= Convert.ToInt64(ask))&&(Convert.ToInt64(ask) <= max))
                {
                    return true;
                }
                else
                {
                    Fn.Msg("Input error!", "Error:\nNumber too large.");
                }
            }
            catch (Exception)
            {
                Fn.Msg("Input error!", "Error:\nExtream input.");
            }
            return false;
        }
    }
}