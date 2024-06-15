using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starships.Types;

namespace Starships.Enumeration
{
    internal class StarType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Classification { get; set; }
        public string? Chromaticity { get; set; }
        public CustomRange TemperatureRange { get; set; }
        public CustomRange MassRange { get; set; }
        public CustomRange RadiusRange { get; set; }
        public CustomRange LuminosityRange { get; set; }
        public CustomRange NameRange { get; set; }
        public float Rarity { get; set; }

        public static StarType O = new StarType(1);
        public static StarType B = new StarType(2);
        public static StarType A = new StarType(3);
        public static StarType F = new StarType(4);
        public static StarType G = new StarType(5);
        public static StarType K = new StarType(6);
        public static StarType M = new StarType(7);
        public static StarType L = new StarType(8);
        public static StarType T = new StarType(9);

        public StarType(int id)
        {
            Id = id;
            Classification = SetClassificationById(id);
            Chromaticity = SetChromaticityById(id);
            TemperatureRange = SetTemperatureRangeById(id);
            MassRange = SetMassRangeById(id);
            RadiusRange = SetRadiusRangeById(id);
            LuminosityRange = SetLuminosityRangeById(id);
            NameRange = SetNameRangeById(id);
            Rarity = SetRarityById(id);
        }

        public StarType(int id, string? name, string? description, string? classification, string? chromaticity, CustomRange temperatureRange, CustomRange massRange, CustomRange radiusRange, CustomRange luminosityRange, CustomRange nameRange, float rarity)
        {
            Id = id;
            Name = name;
            Description = description;
            Classification = classification;
            Chromaticity = chromaticity;
            TemperatureRange = temperatureRange;
            MassRange = massRange;
            RadiusRange = radiusRange;
            LuminosityRange = luminosityRange;
            NameRange = nameRange;
            Rarity = rarity;
        }

        protected static string SetClassificationById(int id)
        {
            switch (id)
            {
                case 1: return "Type-O";
                case 2: return "Type-B";
                case 3: return "Type-A";
                case 4: return "Type-F";
                case 5: return "Type-G";
                case 6: return "Type-K";
                case 7: return "Type-M";
                case 8: return "Type-L";
                case 9: return "Type-T";
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static string SetChromaticityById(int id)
        {
            switch (id)
            {
                case 1: return "blue";
                case 2: return "deep bluish white";
                case 3: return "bluish white";
                case 4: return "white";
                case 5: return "yellowish white";
                case 6: return "pale yellowish orange";
                case 7: return "light orangish red";
                case 8: return "deep dark red";
                case 9: return "deep infrared";
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static CustomRange SetTemperatureRangeById(int id)
        {
            switch (id)
            {
                case 1: return new CustomRange(30000, 52000);
                case 2: return new CustomRange(10000, 30000);
                case 3: return new CustomRange(7500, 10000);
                case 4: return new CustomRange(6000, 7500);
                case 5: return new CustomRange(5200, 6000);
                case 6: return new CustomRange(3700, 5200);
                case 7: return new CustomRange(2400, 3700);
                case 8: return new CustomRange(1300, 2400);
                case 9: return new CustomRange(550, 1300);
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static CustomRange SetMassRangeById(int id)
        {
            switch (id)
            {
                case 1: return new CustomRange(16F, 120F);
                case 2: return new CustomRange(2.1F, 16F);
                case 3: return new CustomRange(1.4F, 2.1F);
                case 4: return new CustomRange(1.04F, 1.4F);
                case 5: return new CustomRange(0.8F, 1.04F);
                case 6: return new CustomRange(0.45F, 0.8F);
                case 7: return new CustomRange(0.08F, 0.45F);
                case 8: return new CustomRange(0.04F, 0.08F);
                case 9: return new CustomRange(0.02F, 0.04F);
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static CustomRange SetRadiusRangeById(int id)
        {
            switch (id)
            {
                case 1: return new CustomRange(6.6F, 12F);
                case 2: return new CustomRange(1.8F, 6.6F);
                case 3: return new CustomRange(1.4F, 1.8F);
                case 4: return new CustomRange(1.15F, 1.4F);
                case 5: return new CustomRange(0.96F, 1.15F);
                case 6: return new CustomRange(0.7F, 0.96F);
                case 7: return new CustomRange(0.5F, 0.7F);
                case 8: return new CustomRange(0.35F, 0.5F);
                case 9: return new CustomRange(0.2F, 0.35F);
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static CustomRange SetLuminosityRangeById(int id)
        {
            switch (id)
            {
                case 1: return new CustomRange(30000F, 50000F);
                case 2: return new CustomRange(25F, 30000F);
                case 3: return new CustomRange(5F, 25F);
                case 4: return new CustomRange(1.5F, 5F);
                case 5: return new CustomRange(0.6F, 1.5F);
                case 6: return new CustomRange(0.08F, 0.6F);
                case 7: return new CustomRange(0.04F, 0.08F);
                case 8: return new CustomRange(0.02F, 0.04F);
                case 9: return new CustomRange(0.01F, 0.02F);
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static CustomRange SetNameRangeById(int id)
        {
            switch (id)
            {
                case 1: return new CustomRange(12, 16);
                case 2: return new CustomRange(12, 16);
                case 3: return new CustomRange(12, 16);
                case 4: return new CustomRange(8, 10);
                case 5: return new CustomRange(5, 8);
                case 6: return new CustomRange(5, 8);
                case 7: return new CustomRange(5, 8);
                case 8: return new CustomRange(5, 8);
                case 9: return new CustomRange(5, 8);
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }

        protected static float SetRarityById(int id)
        {
            switch (id)
            {
                case 1: return 0.00003F;
                case 2: return 0.12F;
                case 3: return 0.61F;
                case 4: return 3F;
                case 5: return 7.6F;
                case 6: return 12F;
                case 7: return 76F;
                case 8: return 0.08F;
                case 9: return 0.008F;
                default: throw new ArgumentException(nameof(id) + " Id not rcognized");
            }
        }
    }
}
