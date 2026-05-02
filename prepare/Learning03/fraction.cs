using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    
    public Fraction( int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        SetBottomNumber(bottom);
    }

    public int GetTopNumber()
    {
        return _numerator;
    }

    public void SetTopNumber(int top)
    {
        _numerator = top;
    }
    
    public int GetBottom()
    {
        return _denominator;
    }

    public void SetBottomNumber(int bottom)
    {
        if (bottom != 0)
        {
            _denominator = bottom;
        }
        else
        {
            _denominator = 1;
        }
    }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimalValue() 
    {
        return (double)_numerator / _denominator;
    }
}