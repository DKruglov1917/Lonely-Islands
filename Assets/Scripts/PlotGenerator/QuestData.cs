using UnityEngine;

public class QuestData
{
    public static string quest;

    private static string[] typeOfQuest = new string[7]
    {
            "Kill",
            "Combo",
            "Delivery",
            "Gather",
            "Escort",
            "Syntax",
            "Hybrid"
    };

    public static void ChooseQuest()
    {
        quest = typeOfQuest[Random.Range(0, 7)];
        // Debug.Log("Your quest is: " + quest);
    }
}