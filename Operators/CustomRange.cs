using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starships.Types
{
    internal class CustomRange
    {
        public int? IntStart { get; }
        public int? IntEnd { get; }
        public float? FloatStart { get; }
        public float? FloatEnd { get; }
        public bool IsFloatRange { get; }
        public Random RandomSeed { get; }

        public CustomRange(int start, int end)
        {
            IntStart = start;
            IntEnd = end;
            RandomSeed = new Random();
            IsFloatRange = false;
        }

        public CustomRange(float start, float end)
        {
            FloatStart = start;
            FloatEnd = end;
            RandomSeed = new Random();
            IsFloatRange = true;
        }

        public int GenerateIntFromRange()
        {
            if (IntStart == null || IntEnd == null)
            {
                throw new ArgumentNullException("Cannot generate int32 from null values");
            }

            if (!IsFloatRange)
            {
                return RandomSeed.Next((int)IntStart, (int)IntEnd);
            }
            else
            {
                throw new ArgumentException("Cannot generate int32 from float values");
            }
        }

        public float GenerateFloatFromRange()
        {
            if (FloatStart == null || FloatEnd == null)
            {
                throw new ArgumentNullException("Cannot generate float from null values");
            }

            if (IsFloatRange)
            {
                return (float)new decimal((double)(RandomSeed.NextDouble() * FloatEnd - FloatStart));
            }
            else
            {
                throw new ArgumentException("Cannot generate float from int values");
            }
        }
    }
}
