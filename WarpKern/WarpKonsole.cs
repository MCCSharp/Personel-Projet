namespace WarpKernSys
{
     class WarpKonsole
    {
        public void WarpTemperaturKontrolle(object sender, WarpEventArgs e)
        {
            Random rnd = new Random();
            var notPwd = rnd.Next(100000, 999999);
            string tempInput=string.Empty;


            int input = 0;
            
            Console.WriteLine($" Achtung Temperatur ist zu hoch. Die tampeartur ist {e.WarpKern!.WarpTemperatur} Grad!");
            Console.WriteLine($" Bitte NotfallKode Eingeben {notPwd}");
            //countdownTh.Start();    
            //while (countdownTh.IsAlive)
            //{

                while (input != notPwd )
                {
                    try
                    {
                        tempInput = Console.ReadLine();
                        input = Convert.ToInt32(tempInput);
                    }
                    catch (InvalidCastException)
                    {
                        Console.WriteLine("Bitte nur Ziffer eingeben");
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Bitte nur Ziffer eingeben");
                    }
                    if (input == notPwd)
                    {
                        e.WarpKern.WarpTemperaturZeiger(10);                 
                    }
                }         
            //}
               
        }       
    }
}