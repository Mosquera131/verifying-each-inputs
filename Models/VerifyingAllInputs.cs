using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace verifyingInputs.Models;

public class Verifying
{
    public static string IpTString(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine() ?? string.Empty;
        return input;
    }

    public static int IpTInt(string prompt)
    {

        Console.Write(prompt);
        int input;
        while (!int.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
        {
            Console.WriteLine("Por favor, ingresa un valor entero");
            Console.Write(prompt);
        }
        return input;
    }

    public static byte IpTByte(string prompt)
    {
        Console.Write(prompt);

        byte input;
        while (!byte.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
        {
            Console.WriteLine("Por favor, ingresa un valor entero");
            Console.Write(prompt);
        }
        return input;
    }

    public static double IpTDouble(string prompt)
    {
        Console.Write(prompt);

        double input;
        while (!double.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
        {
            Console.WriteLine("Por favor, ingresa un valor numérico");
            Console.Write(prompt);
        }
        return input;
    }
    public static DateTime IpTDate(string prompt)
    {
        Console.Write(prompt);
        DateTime input;
        while (!DateTime.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Por favor, ingresa una fecha válida:");
            Console.Write(prompt);
        }
        return input;
    }

    public static DateOnly IpTDateOnly(string prompt)
    {
        Console.Write(prompt);
        DateTime tempDateTime;
        while (!DateTime.TryParse(Console.ReadLine(), out tempDateTime))
        {
            Console.WriteLine("Por favor, ingresa una fecha válida:");
            Console.Write(prompt);
        }
        return DateOnly.FromDateTime(tempDateTime);
    }

}
