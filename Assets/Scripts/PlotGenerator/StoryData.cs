using UnityEngine;

public class StoryData
{
    public static string[][] stories = new string[36][]
        {
            new string[]{ "The suppliant appeals to the power in authority for deliverance from the persecutor."},
            new string[]{ "The unfortunate has caused a conflict, and the threatener is to carry out justice, but the rescuer saves the unfortunate."},
            new string[]{ "The criminal commits a crime that will not see justice, so the avenger seeks justice by punishing the criminal."},
            new string[]{ "Two entities, the Guilty and the Avenging Kinsmen, are put into conflict over wrongdoing to the Victim, who is allied to both."},
            new string[]{ "The fugitive flees punishment for a misunderstood conflict."},
            new string[]{ "The vanquished power falls from their place after being defeated by the victorious enemy or being informed of such a defeat by the messenger."},
            new string[]{ "The unfortunate suffers from misfortune and/or at the hands of the master."},
            new string[]{ "The tyrant, a cruel power, is plotted against by the conspirator."},
            new string[]{ "The bold leader takes the object from the adversary by overpowering the adversary."},
            new string[]{ "The abductor takes the abducted from the guardian."},

            new string[]{ "The interrogator poses a problem to the seeker and gives a seeker better ability to reach the seeker's goals."},
            new string[]{ "The solicitor is at odds with the adversary who refuses to give the solicitor an object in the possession of the adversary"},
            new string[]{ "The Malevolent Kinsman and the Hated or a second Malevolent Kinsman conspire together."},
            new string[]{ "The Object of Rivalry chooses the Preferred Kinsman over the Rejected Kinsman."},
            new string[]{ "Two Adulterers conspire to kill the Betrayed Spouse."},
            new string[]{ "The Madman goes insane and wrongs the Victim."},
            new string[]{ "The Imprudent, by neglect or ignorance, loses the Object Lost or wrongs the Victim."},
            new string[]{ "The Lover and the Beloved have unknowingly broken a taboo through their romantic relationship, and the Revealer reveals this to them."},
            new string[]{ "The Slayer kills the Unrecognized Victim."},
            new string[]{ "The Hero sacrifices the Person or Thing for their Ideal, which is then taken by the Creditor."},

            new string[]{ "The Hero sacrifices a Person or Thing for their Kinsman, which is then taken by the Creditor."},
            new string[]{ "A Lover sacrifices a Person for the Object of their Passion, which is then lost forever."},
            new string[]{ "The Hero wrongs the Beloved Victim because of the Necessity for their Sacrifice."},
            new string[]{ "An Inferior Rival bests a Superior Rival and wins the Object of Rivalry."},
            new string[]{ "Two Adulterers conspire against the Deceived Spouse."},
            new string[]{ "A Lover and the Beloved break a taboo by initiating a romantic relationship."},
            new string[]{ "The Discoverer discovers the wrongdoing committed by the Guilty One."},
            new string[]{ "Two Lovers face an Obstacle together."},
            new string[]{ "The allied Lover and Hater have diametrically opposed attitudes towards the Beloved Enemy."},
            new string[]{ "The Ambitious Person seeks the Thing Coveted and is opposed by the Adversary."},

            new string[]{ "The Mortal and the Immortal enter a conflict."},
            new string[]{ "The Jealous One falls victim to the Author of the Mistake and becomes jealous of the Object and becomes conflicted with the Supposed Accomplice."},
            new string[]{ "The Mistaken One falls victim to the Author of the Mistake and passes judgment against the Victim of the Mistake when it should be passed against the Guilty One instead."},
            new string[]{ "The Culprit wrongs the Victim or commits the Sin, and is at odds with the Interrogator who seeks to understand the situation."},
            new string[]{ "The Seeker finds the One Found."},
            new string[]{ "The killing of the Kinsman Slain by the Executioner is witnessed by the Kinsman." }
        };

    public static void WriteStory(int poltiValue)
    {
        Debug.Log(poltiValue + stories[poltiValue][0]);
    }

}
