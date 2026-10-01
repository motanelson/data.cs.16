namespace Cosmosangle
{
    public class Kernel 
    {

        public static void Main()
        {
            Run();
        }

        public static void Run()
        {
            while (true)
            {
                double d = 360.00;
                double dd = 16.00;
                double ddd = d / dd;
                double d1 = 2.00 * Math.PI;
                double d2 = d1 / dd;
                string s = "";
                string ss = "double dcos= {";
                string sss = "double dsin= {";
                int i = 0;

                Console.BackgroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                var input = "";// Console.ReadLine();
                for (i = 0; i < 16; i++)
                {
                    
                    
                    s = (Math.Cos(((double)i) * d2)).ToString();
                    s = s.Replace(",", ".");
                    if (s.Length > 6)
                    {
                        s = s.Substring(0, 6);
                        s = s + " , ";
                        ss= ss + s;
                    }
                    else
                    {
                        
                        s = s + " , ";
                        ss = ss + s;

                    }
                    
                    s = (Math.Sin(((double)i) * d2)).ToString();
                    s = s.Replace(",", ".");
                    if (s.Length > 6)
                    {
                        s = s.Substring(0, 6);
                        s = s + " , ";
                        sss =sss+s;
                    }
                    else
                    {
                        
                        s = s + " , ";
                        sss =sss+ s;

                    }
                    
                    
                    
                }
                Console.WriteLine(ss+"0.00 }\n");
                Console.WriteLine(sss + "0.00 }\n");
                input = Console.ReadLine();


            }
        }
    }
}