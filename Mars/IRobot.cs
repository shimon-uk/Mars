using System;
namespace Mars
{
    public interface IRobot
    {
        Compass Direction { get; set; }
        void ProcessCommand();
        System.Collections.Generic.List<char> RoamCoordinates { get; set; }
        ILandingSurface Surface { get; set; }
        bool ValidateData(ILandingSurface Surface, int x, int y, string roamCoords);
        int X { get; set; }
        int Y { get; set; }
        string Status { get; set; }


        void ExceptCommand(int x, int y, Compass direction, string roamCoords);
    }
}
