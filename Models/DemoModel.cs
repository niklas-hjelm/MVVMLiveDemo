namespace MVVMLiveDemo.Models;

public class DemoModel
{
    public string MyText { get; set; }

    /// <summary>
    /// Metod som returnerar MyText omvänt
    /// Anropas från DemoCommand.Execute
    /// </summary>
    /// <returns></returns>
    public string ReverseMyText()
    {
        var output = string.Empty;

        for (int i = MyText.Length - 1; i >= 0; i--)
        {
            output += MyText[i];
        }

        return output;
    }
}