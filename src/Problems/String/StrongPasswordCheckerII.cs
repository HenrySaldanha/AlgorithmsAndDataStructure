namespace Problems.String;

/// <summary>
/// A password is said to be strong if it satisfies all the following criteria:
/// It has at least 8 characters.
/// It contains at least one lowercase letter.
/// It contains at least one uppercase letter.
/// It contains at least one digit.
/// It contains at least one special character. The special characters are the characters in the following string: "!@#$%^&*()-+".
/// It does not contain 2 of the same character in adjacent positions (i.e., "aab" violates this condition, but "aba" does not).
/// Given a string password, return true if it is a strong password.Otherwise, return false.
/// </summary>

/// <example>
/// Input: password = "IloveLe3tcode!"
/// Output: true
/// </example>
/// 
/// <example>
/// Input: password = "Me+You--IsMyDream"
/// Output: false
/// </example>

public class StrongPasswordCheckerII
{
    public bool Solution(string password)
    {
        if (password.Length < 8 ||
            !password.Any(char.IsLower) ||
            !password.Any(char.IsUpper) ||
            !password.Any(char.IsDigit) ||
            !password.Any("!@#$%^&*()-+".Contains))
            return false;

        for (var i = 0; i < password.Length - 1; i++)
        {
            if (password[i] == password[i + 1])
                return false;
        }

        return true;
    }
}