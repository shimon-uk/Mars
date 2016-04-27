using System;
namespace Mars
{
   public interface ILandingSurface
    {
        int X_Max { get; set; }
        int X_Min { get; set; }
        int Y_Max { get; set; }
        int Y_Min { get; set; }
    }
}
