class Temperatura
{
    public double Celsius
    {
        get;
        set
        {
            if (value < -273.15)
                throw new ArgumentOutOfRangeException(nameof(value));
            field = value;
        }
    }

    public double Fahrenheit => Celsius * 9 / 5 + 32;
}