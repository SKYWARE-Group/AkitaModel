using System.Text;

namespace AkitaModelDemo.Helpers;

public class Utilities
{

    private const string STARTING_RANDOM_SET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private const int DEFAULT_RANDOM_LENGHT = 5;
    private readonly static Random random = new();

    /// <summary>
    /// Generates uppercase random alpha-numeric string, e.g. "A45FT".
    /// </summary>
    /// <param name="Length"></param>
    /// <returns></returns>
    public static string GetRandomString(int Length = DEFAULT_RANDOM_LENGHT)
    {
        if (Length <= 0)
            return "";

        var result = new StringBuilder();
        for (int i = 1; i <= Length; i++)
        {
            int index = random.Next(0, STARTING_RANDOM_SET.Length);
            result.Append(STARTING_RANDOM_SET.Substring(index, 1));
        }
        return result.ToString();
    }

}
