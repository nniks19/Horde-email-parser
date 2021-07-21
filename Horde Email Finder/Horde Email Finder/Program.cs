using System;

namespace Horde_Email_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"INBOX.Sent.MBOX");
            System.IO.StreamWriter sw = new System.IO.StreamWriter("Emails.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.StartsWith("To: <"))
                {
                    string sEmail = line.Replace("To: <", "");
                    sEmail = sEmail.Replace(">", "");
                    sEmail = sEmail.Replace("mailto:", "");
                    sw.WriteLine(sEmail);
                    System.Console.WriteLine(sEmail);
                    counter++;
                }
            }
            sw.Close();
            file.Close();
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
