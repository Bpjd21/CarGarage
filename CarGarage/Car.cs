using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; set; }
        public int FuelLevel { get; set;}
        public bool EngineOn = true;

        public Car()
        {
            Speed = 0;
            FuelLevel = 100;
            EngineOn = true;
        }

        public void Accelerate()
        {
            Speed += 10;
            FuelLevel -= 2;
        }

        public void AddFuel()
        {
            FuelLevel = 100;
        }

        
        public void Brake()
        {
            if(Speed >= 10)
            {
                Speed -= 10;
            }
            else
                return;            
        }

        public void ToggleEngine()
        {
            if (EngineOn)
            {
                EngineOn = true;
            }
            else
            {
                EngineOn = false;
            }
        }

    }
}
