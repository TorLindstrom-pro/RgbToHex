using System;

namespace RgbToHex;

public class Kata
{
    public static string Rgb(int r, int g, int b) 
    {
        return TranslateToHex(r) + TranslateToHex(g) + TranslateToHex(b);
    }
    
    private static string TranslateToHex(int value)
    {
        return value switch
        {
            < 0 => "00",
            > 255 => "FF",
            _ => value.ToString("X2")
        };
    }
}