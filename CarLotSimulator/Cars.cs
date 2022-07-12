using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Cars
    {
        public Cars(int year, string make, string model, string engineNoise, string honkNoise, bool isDirveable)
        {
            Year1 = year;
            Make2 = make;
            Model2 = model;
            EngineNoise2 = engineNoise;
            HonkNoise2 = honkNoise;
            IsDirveable2 = isDirveable;
        }

        public int Year1 { get; set; }

        public string Make2 { get; set; }

        public string Model2 { get; set; }

        public string EngineNoise2 { get; set; }

        public string HonkNoise2 { get; set; }

        public bool IsDirveable2 { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise2);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise2);
        }

    }
}
