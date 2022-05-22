namespace App
{
    public class Quality
    {
        public int value {get; private set; }

        public Quality(int value = 0)
        {
            this.value = value;
        }

        public static Quality operator++ (Quality quality)
        {
            if (quality.value < 50)
            {
                quality.value++;
            }

            return quality;
        }

        public static Quality operator-- (Quality quality)
        {
            if (quality.value > 0)
            {
                quality.value--;
            }

            return quality;
        }

        public static implicit operator int(Quality quality)
        {
            return quality.value;
        }

        public static  implicit operator Quality(int quality)
        {
            return new Quality(quality);
        }
    }
}
