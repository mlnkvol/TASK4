using System;

public class River : GeographicalObject, IGeographicalObject
{
    public double FlowSpeed { get; set; }

    public double TotalLength { get; set; }

    public override string GetInformation()
    {
        return base.GetInformation() + $"\nFlow Speed: {FlowSpeed} cm/s\nTotal Length: {TotalLength} km";
    }
}

