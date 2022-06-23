namespace Problems.String;

/// <summary>
/// Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.
/// A -> 1
/// B -> 2
/// C -> 3
/// ...
/// Z -> 26
/// AA -> 27
/// AB -> 28 
/// ...
/// </summary>

/// <example>
/// Input: columnTitle = "A"
/// Output: 1
/// </example>

/// <example>
/// Input: columnTitle = "ZY"
/// Output: 701
/// </example>

public class ExcelSheetColumnNumber
{
    public int Solution(string columnTitle)
    {
        var number = 0;

        for (int i = 0; i < columnTitle.Length; i++)
            number = (columnTitle[i] - 'A' + 1) + (26 * number);

        return number;
    }
}