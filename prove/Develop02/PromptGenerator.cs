using System;

public class PromptGenerator
{
    public static Random randomGenerator = new Random();
    public static string GetRandomPrompt()
    {
        int randomNumber = randomGenerator.Next(0,3);
 
        string[] writingPrompt = new string[4];
        writingPrompt[0] = "How is your family today? Are you happy and trying your best?:";
        writingPrompt[1] = "Have you tried your hardest today? Why or why not?:";
        writingPrompt[2] = "What could have you done better today?";
        writingPrompt[3] = "Who have you helped today or been kind to? What did you do?";
        return writingPrompt[randomNumber];
    }
}