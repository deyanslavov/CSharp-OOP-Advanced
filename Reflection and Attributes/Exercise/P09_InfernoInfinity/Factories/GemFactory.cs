using System;

public class GemFactory : IGemFactory
{
    public IGem CreateGem(string gemClass, string clarity)
    {
        GemClarity gemClarity;
        var isGemValid = Enum.TryParse(clarity, out gemClarity);

        if (!isGemValid)
        {
            return null;
        }

        var gemType = Type.GetType(gemClass + "Gem");

        return (IGem)Activator.CreateInstance(gemType, new object[] { gemClarity });
    }
}
