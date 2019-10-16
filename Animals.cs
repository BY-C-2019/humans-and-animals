using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Elephant 
    {

        public int elephantHungerValue = 0;

        public void ElephantHunger()
        {
            
            elephantHungerValue++;
            if(elephantHungerValue == 10){
                System.Console.WriteLine("Elefanten Magnus är hungrig och äter några äpplen.");
                elephantHungerValue = 0;
                Program.nrOfVeggiesLeft--;

            }else{
                System.Console.WriteLine("Elefantens hungernivå: " + elephantHungerValue);
            

            }
                
        }
    }    


    

    class Giraffe
    {
        
        public int giraffeHungerValue;
        
        public void GiraffeHunger()
        {
            


            giraffeHungerValue++;
        
            if(giraffeHungerValue == 7)
            {
                System.Console.WriteLine("Giraffen Sten-Sture Larsson är hungrig och äter några blad.");
                giraffeHungerValue = 0;
                Program.nrOfVeggiesLeft--;


            }
            else
            {
                System.Console.WriteLine("Giraffens hungernivå: " + giraffeHungerValue);
            }
        
        
        }

    
    
    }   
    class Coyote 
    {
        public int coyoteHungerValue;

        public void CoyoteHunger()
        {
            coyoteHungerValue++;
            if(coyoteHungerValue == 15)
            {
                System.Console.WriteLine("Prärievargarna är hungriga och käkar några fläskkotletter.");
                coyoteHungerValue = 0;
                Program.nrOfMeatLeft--;
            }
            else
            {
                System.Console.WriteLine("Prärievargarnas hungernivå: " + coyoteHungerValue);


            }
            


    
        }
    }
    class Seals 
    {
        int sealHungerValue;
        public void SealHunger()
        {

            sealHungerValue++;
            if(sealHungerValue == 13)
            {
                System.Console.WriteLine("Sälarna är hungriga och käkar några sillar.");
                sealHungerValue = 0;
                Program.nrOfMeatLeft--;

            }else
            {
                System.Console.WriteLine("Sälarnas hungernivå: " + sealHungerValue);
            }



        }


    }


    class Bear
    {
        int bearHungerValue;

        public void BearHunger()
        {
            bearHungerValue++;

            if(bearHungerValue == 3)
            {

                System.Console.WriteLine("Björen Karl-Olof är hungrig och käkar några lövbiffar.");
                bearHungerValue = 0;
                Program.nrOfMeatLeft--;
            }
            else
            {
                System.Console.WriteLine("Björnens hungernivå: " + bearHungerValue);


        
            }


        }

    }




}




