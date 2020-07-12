/*
This example demonstrates the CursorLeft and CursorTop properties,
and the SetCursorPosition and Clear methods.
The example positions the cursor, 
which determines where the next write will occur,
to draw a 5 character by 5 character rectangle using
a combination of "+", "|", and "-" strings. 
Note that the rectangle could be drawn with
fewer steps using a combination of other strings. 
 */
using System;

class ByDenisRafi
{
    protected static int origRow;
    protected static int origCol;

    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }
    public static void Main()
    {
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        WriteAt("+", 0, 0);
        WriteAt("|", 0, 1);
        WriteAt("|", 0, 2);
        WriteAt("|", 0, 3);
        WriteAt("+", 0, 4);

        WriteAt("-", 1, 4); 
        WriteAt("-", 2, 4); 
        WriteAt("-", 3, 4); 
        WriteAt("+", 4, 4);

        WriteAt("|", 4, 3);
        WriteAt("|", 4, 2);
        WriteAt("|", 4, 1);
        WriteAt("+", 4, 0);

        WriteAt("-", 3, 0); 
        WriteAt("-", 2, 0); 
        WriteAt("-", 1, 0); 
                            
        WriteAt("By Denis Rafi!", 0, 6);
        Console.Title = "CursorTop";
        Console.WriteLine();
        Console.ReadKey();
    }
}

