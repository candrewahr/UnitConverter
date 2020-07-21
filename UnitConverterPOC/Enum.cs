using System;
namespace UnitConverterPOC
{

    //Volume and Weight don't have the same conversion factor accross all substances,
    //but for the exercise we can go ahead and assume all substances have the same density.
    public enum WeightAndVolumeEnum
    {
        G,
        L,
        LB,      
        KG
    }

    public enum LengthEnum
    {
        IN,
        CM,
        FT,
        YD
    }
}
