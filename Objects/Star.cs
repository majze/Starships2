using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starships.Enumeration;

namespace Starships.Objects
{
    internal class Star
    {
        public StarType StarType { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Temperature { get; set; }
        public float Mass { get; set; }
        public float Radius { get; set; }
        public float Luminosity { get; set; }

        public Star(StarType starType)
        {
            StarType = starType;
            GenerateProperties();
        }

        protected void GenerateProperties()
        {
            if (StarType == null)
            {
                throw new NullReferenceException("StarType must be set in constructor parameter before remaining properties can be generated");
            }

            Name = GenerateName();
            Temperature = StarType.TemperatureRange.GenerateIntFromRange();
            Mass = StarType.MassRange.GenerateFloatFromRange();
            Radius = StarType.RadiusRange.GenerateFloatFromRange();
            Luminosity = StarType.LuminosityRange.GenerateFloatFromRange();
        }

        protected string GenerateName()
        {
            int nameLength = StarType.NameRange.GenerateIntFromRange() + 1;
            int hyphenPosition = StarType.NameRange.RandomSeed.Next((int)(StarType.NameRange.IntStart - nameLength / 3), nameLength - nameLength / 3);
            List<char> nameValues = new List<char>();

            for (int i = 0; i < nameLength; i++)
            {
                if (i < hyphenPosition)
                {
                    int charNumericValue = StarType.NameRange.RandomSeed.Next(0, 26);
                    nameValues.Add(Convert.ToChar('A' + charNumericValue));
                }
                else if (i == hyphenPosition)
                {
                    nameValues.Add('-');
                }
                else
                {
                    int charNumericValue = StarType.NameRange.RandomSeed.Next(0, 10);
                    nameValues.Add((char)('0' + charNumericValue));
                }
            }

            return new string(nameValues.ToArray());
        }

        protected void setName(string name)
        {
            Name = name;
        }
    }
}
