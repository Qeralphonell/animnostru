using System;

public class TextElement
{
    // Private field to hold the font attribute value.
    private string _font;

    /// <summary>
    /// A property for accessing a font attribute.
    /// </summary>
    public string Font
    {
        get { return _font; }
        set { _font = value; }
    }

    // Constructor to initialize the font attribute.
    public TextElement(string font)
    {
        _font = font;
    }

    // Override ToString() method to display the font attribute.
    public override string ToString()
    {
        return $"Font: {_font}";
    }

    // Main method for testing purposes.
    public static void Main(string[] args)
    {
        TextElement textElement = new TextElement("Arial");
        Console.WriteLine(textElement); // Output: Font: Arial

        // Change the font attribute.
        textElement.Font = "Times New Roman";
        Console.WriteLine(textElement); // Output: Font: Times New Roman
    }
}
