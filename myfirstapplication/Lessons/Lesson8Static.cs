namespace myfirstapplication;

internal static class Lesson8Static
{
    public static double CelsiustoFaren(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FarentoCelsius(double faren)
    {
        return (faren - 32) * 5 / 9;
    }

}

