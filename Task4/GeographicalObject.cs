using System;

public abstract class GeographicalObject
{
    public double X { get; set; }

    public double Y { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public virtual string GetInformation()
    {
        return $"Name: {Name}\nDescription: {Description}\nCoordinates: ({X}, {Y})";
    }
}
