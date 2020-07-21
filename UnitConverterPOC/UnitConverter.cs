using System;
namespace UnitConverterPOC
{
    public static class UnitConverter
    {
        /// <summary>
        /// Converts from one unit of weight / mass to another.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="convertTo"></param>
        /// <param name="convertFrom"></param>
        /// <returns></returns>
        public static double WeightAndVolumeConvertTo(double value, WeightAndVolumeEnum convertTo, WeightAndVolumeEnum convertFrom)
        {
            switch (convertTo)
            {
                case WeightAndVolumeEnum.G:
                    if (convertFrom == WeightAndVolumeEnum.L)
                    {
                        value /= 3.8;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.LB)
                    {
                        value /= 8;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.KG)
                    {
                        value /= 3.79;
                    }                  
                    break;
                case WeightAndVolumeEnum.L:
                    if (convertFrom == WeightAndVolumeEnum.G)
                    {
                        value *= 3.8;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.LB)
                    {
                        value /= 2.2;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.KG)
                    {
                        //do nothing... it's one to one. 
                    }

                    break;
                case WeightAndVolumeEnum.LB:
                    if (convertFrom == WeightAndVolumeEnum.G)
                    {
                        value *= 8;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.L)
                    {
                        value *= 2.2;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.KG)
                    {
                        value *= 2.2;
                    }

                    break;

                case WeightAndVolumeEnum.KG:
                    if (convertFrom == WeightAndVolumeEnum.G)
                    {
                        value *= 3.79;
                    }
                    else if (convertFrom == WeightAndVolumeEnum.L)
                    {
                        //do nothing... it's one to one. 
                    }
                    else if (convertFrom == WeightAndVolumeEnum.LB)
                    {
                        value /= 2.2;
                    }

                    break;
            }

            return value;
        }

        /// <summary>
        /// Converts from one unit of length to another.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="convertTo"></param>
        /// <param name="convertFrom"></param>
        /// <returns></returns>
        public static double LengthConvertTo(double value, LengthEnum convertTo, LengthEnum convertFrom)
        {
            switch (convertTo)
            {
                case LengthEnum.IN:
                    if (convertFrom == LengthEnum.FT)
                    {
                        value *= 12;
                    }
                    else if (convertFrom == LengthEnum.YD)
                    {
                        value *= 36;
                    }
                    else if (convertFrom == LengthEnum.CM)
                    {
                        value /= 2.54;
                    }
                    break;
                case LengthEnum.FT:
                    if (convertFrom == LengthEnum.IN)
                    {
                        value /= 12;
                    }
                    else if (convertFrom == LengthEnum.YD)
                    {
                        value *= 3;
                    }
                    else if (convertFrom == LengthEnum.CM)
                    {
                        value /= 30.48;
                    }

                    break;
                case LengthEnum.YD:
                    if (convertFrom == LengthEnum.FT)
                    {
                        value /= 3;
                    }
                    else if (convertFrom == LengthEnum.IN)
                    {
                        value /= 36;
                    }
                    else if (convertFrom == LengthEnum.CM)
                    {
                        value /= 91.44;
                    }

                    break;

                case LengthEnum.CM:
                    if (convertFrom == LengthEnum.IN)
                    {
                        value *= 2.54;
                    }
                    else if (convertFrom == LengthEnum.FT)
                    {
                        value *= 30.48;
                    }
                    else if (convertFrom == LengthEnum.YD)
                    {
                        value *= 91.44;
                    }

                    break;
            }
            return value;
        }
    }
}

