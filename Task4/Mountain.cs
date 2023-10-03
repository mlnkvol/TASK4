using System;

public class Mountain : GeographicalObject, IGeographicalObject
{
    public double HighestPoint { get; set; }

    public override string GetInformation()
    {
        return base.GetInformation() + $"\nHighest Point: {HighestPoint} meters above sea level";
    }
}
