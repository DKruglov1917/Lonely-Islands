using System.Collections.Generic;
using UnityEngine;

class CharacterData
{
    public static int poltiValue;

    //36 Polti`s situations
    private string[] situation = new string[36]
    {
                "Supplication", "Deliverance", "Crime pursued by vengeance",
                "Vengeance taken for kin upon kin", "Pursuit", "Disaster",
                "Falling prey to cruelty/misfortune", "Revolt", "Daring enterprise",
                "Abduction", "The enigma", "Obtaining",
                "Enmity of kin", "Rivalry of kin", "Murderous adultery",
                "Madness", "Fatal imprudence", "Involuntary crimes of love",
                "Slaying of kin unrecognized", "Self-sacrifice for an ideal", "Self-sacrifice for kin",
                "All sacrificed for passion", "Necessity of sacrificing loved ones", "Rivalry of superior vs. inferior",
                "Adultery", "Crimes of love", "Discovery of the dishonour of a loved one",
                "Obstacles to love", "An enemy loved", "Ambition",
                "Conflict with a god", "Mistaken jealousy", "Erroneous judgment",
                "Remorse", "Recovery of a lost one", "Loss of loved ones"
    };

    public static string[][] characters = new string[36][]
    {
                new string[]{ "suppliant", "power in authority", "persecutor"},
                new string[] { "unfortunate", "threatener", "rescuer" },
                new string[] { "criminal", "avenger" },

                new string[]{ "Guilty Kinsman", "Avenging Kinsman",
                              "remembrance of the Victim" },
                new string[] { "punishment", "fugitive" },
                new string[] { "vanquished power", "victorious enemy" },

                new string[] { "unfortunate", "master" },
                new string[] { "tyrant", "conspirator" },
                new string[] { "bold leader", "object", "adversary" },

                new string[] { "abductor", "abducted", "guardian" },
                new string[] { "problem", "interrogator", "seeker" },
                new string[] { "arbitrator", "opposing parties" },

                new string[] { "Malevolent Kinsman", "Hated" },
                new string[]{ "Preferred Kinsman", "Rejected Kinsman",
                              "Object of Rivalry" },
                new string[] { "first Adulterer", "second Adulterer", "Betrayed Spouse" },

                new string[] { "Madman", "Victim" },
                new string[] { "Imprudent", "Victim" },
                new string[] { "Lover", "Beloved", "Revealer" },

                new string[] { "Slayer", "Unrecognized Victim" },
                new string[] { "Hero", "Ideal", "Creditor" },
                new string[] { "Hero", "Kinsman", "Person/Thing sacrificed" },

                new string[]{ "Lover", "Object of fatal Passion",
                              "Thing sacrificed" },
                new string[]{ "Hero", "Beloved Victim",
                              "Necessity for the Sacrifice" },
                new string[]{ "Superior Rival", "Inferior Rival",
                              "Object of Rivalry" },

                new string[] { "first Adulterer", "second Adulterer", "Deceived Spouse" },
                new string[] { "Lover", "Beloved" },
                new string[] { "Discoverer", "Guilty One" },

                new string[] { "first Lover", "second Lover", "Obstacle" },
                new string[] { "Lover", "Beloved Enemy", "Hater" },
                new string[] { "Ambitious Person", "Thing Coveted", "Adversary" },

                new string[] { "Mortal", "Immortal" },
                new string[]{ "Jealous One", "Object of whose Possession He is Jealous",
                              "Supposed Accomplice", "Cause"},
                new string[]{ "Mistaken One", "Victim of the Mistake",
                              "Cause", "the Guilty One"},

                new string[] { "Culprit", "Victim", "Interrogator" },
                new string[] { "Seeker", "One Found" },
                new string[] { "Kinsman Slain", "Kinsman Spectator", "Executioner" },
    };

    private static string[] typeOfCharacter = new string[3] { "Man", "God", "Fact" };

    public static Dictionary<string, string> TypeOfCharacterDictionary = new Dictionary<string, string>()
    {
        [characters[0][0]] = typeOfCharacter[0],
        [characters[0][1]] = typeOfCharacter[0],
        [characters[0][2]] = typeOfCharacter[0],

        [characters[1][0]] = typeOfCharacter[0],
        [characters[1][1]] = typeOfCharacter[0],
        [characters[1][2]] = typeOfCharacter[0],

        [characters[2][0]] = typeOfCharacter[0],
        [characters[2][1]] = typeOfCharacter[0],

        [characters[3][0]] = typeOfCharacter[0],
        [characters[3][1]] = typeOfCharacter[0],
        [characters[3][2]] = typeOfCharacter[0],

        [characters[4][0]] = typeOfCharacter[2],
        [characters[4][1]] = typeOfCharacter[0],

        [characters[5][0]] = typeOfCharacter[0],
        [characters[5][1]] = typeOfCharacter[0],

        [characters[6][0]] = typeOfCharacter[0],
        [characters[6][1]] = typeOfCharacter[0],

        [characters[7][0]] = typeOfCharacter[0],
        [characters[7][1]] = typeOfCharacter[0],

        [characters[8][0]] = typeOfCharacter[0],
        [characters[8][1]] = typeOfCharacter[2],
        [characters[8][2]] = typeOfCharacter[0],

        [characters[9][0]] = typeOfCharacter[0],
        [characters[9][1]] = typeOfCharacter[0],
        [characters[9][2]] = typeOfCharacter[0],

        [characters[10][0]] = typeOfCharacter[0],
        [characters[10][1]] = typeOfCharacter[0],
        [characters[10][2]] = typeOfCharacter[0],

        [characters[11][0]] = typeOfCharacter[0],
        [characters[11][1]] = typeOfCharacter[0],

        [characters[12][0]] = typeOfCharacter[0],
        [characters[12][1]] = typeOfCharacter[0],

        [characters[13][0]] = typeOfCharacter[0],
        [characters[13][1]] = typeOfCharacter[0],
        [characters[13][2]] = typeOfCharacter[2],

        [characters[14][0]] = typeOfCharacter[0],
        [characters[14][1]] = typeOfCharacter[0],
        [characters[14][2]] = typeOfCharacter[0],

        [characters[15][0]] = typeOfCharacter[0],
        [characters[15][1]] = typeOfCharacter[0],

        [characters[16][0]] = typeOfCharacter[0],
        [characters[16][1]] = typeOfCharacter[0],

        [characters[17][0]] = typeOfCharacter[0],
        [characters[17][1]] = typeOfCharacter[0],
        [characters[17][2]] = typeOfCharacter[0],

        [characters[18][0]] = typeOfCharacter[0],
        [characters[18][1]] = typeOfCharacter[0],

        [characters[19][0]] = typeOfCharacter[0],
        [characters[19][1]] = typeOfCharacter[2],
        [characters[19][2]] = typeOfCharacter[0],

        [characters[20][0]] = typeOfCharacter[0],
        [characters[20][1]] = typeOfCharacter[0],
        [characters[20][2]] = typeOfCharacter[0],

        [characters[21][0]] = typeOfCharacter[0],
        [characters[21][1]] = typeOfCharacter[0],
        [characters[21][2]] = typeOfCharacter[2],

        [characters[22][0]] = typeOfCharacter[0],
        [characters[22][1]] = typeOfCharacter[0],
        [characters[22][2]] = typeOfCharacter[2],

        [characters[23][0]] = typeOfCharacter[0],
        [characters[23][1]] = typeOfCharacter[0],
        [characters[23][2]] = typeOfCharacter[2],

        [characters[24][0]] = typeOfCharacter[0],
        [characters[24][1]] = typeOfCharacter[0],
        [characters[24][2]] = typeOfCharacter[0],

        [characters[25][0]] = typeOfCharacter[0],
        [characters[25][1]] = typeOfCharacter[0],

        [characters[26][0]] = typeOfCharacter[0],
        [characters[26][1]] = typeOfCharacter[0],

        [characters[27][0]] = typeOfCharacter[0],
        [characters[27][1]] = typeOfCharacter[0],
        [characters[27][2]] = typeOfCharacter[2],

        [characters[28][0]] = typeOfCharacter[0],
        [characters[28][1]] = typeOfCharacter[0],
        [characters[28][2]] = typeOfCharacter[0],

        [characters[29][0]] = typeOfCharacter[0],
        [characters[29][1]] = typeOfCharacter[2],
        [characters[29][2]] = typeOfCharacter[0],

        [characters[30][0]] = typeOfCharacter[0],
        [characters[30][1]] = typeOfCharacter[1],

        [characters[31][0]] = typeOfCharacter[0],
        [characters[31][1]] = typeOfCharacter[0],
        [characters[31][2]] = typeOfCharacter[0],
        [characters[31][3]] = typeOfCharacter[2],

        [characters[32][0]] = typeOfCharacter[0],
        [characters[32][1]] = typeOfCharacter[0],
        [characters[32][2]] = typeOfCharacter[2],
        [characters[32][3]] = typeOfCharacter[0],

        [characters[33][0]] = typeOfCharacter[0],
        [characters[33][1]] = typeOfCharacter[0],
        [characters[33][2]] = typeOfCharacter[0],

        [characters[34][0]] = typeOfCharacter[0],
        [characters[34][1]] = typeOfCharacter[0],

        [characters[35][0]] = typeOfCharacter[0],
        [characters[35][1]] = typeOfCharacter[0],
        [characters[35][2]] = typeOfCharacter[0]
    };

    private static string[] genders = new string[3] { "m", "f", "n" };

    private static string[] maleNames = new string[100]
        {
                "Liam","Noah","Oliver","Elijah","William",
                "James","Benjamin","Lucas","Henry","Alexander",
                "Mason","Michael","Ethan","Daniel","Jacob",
                "Logan","Jackson","Levi","Sebastian","Mateo",
                "Jack","Owen","Theodore","Aiden","Samuel",
                "Joseph","John","David","Wyatt","Matthew",
                "Luke","Asher","Carter","Julian","Grayson",
                "Leo","Jayden","Gabriel","Isaac","Lincoln",
                "Anthony","Hudson","Dylan","Ezra","Thomas",
                "Charles","Christopher","Jaxon","Maverick","Josiah",
                "Isaiah","Andrew","Elias","Joshua","Nathan",
                "Caleb","Ryan","Adrian","Miles","Eli",
                "Nolan","Christian","Aaron","Cameron","Ezekiel",
                "Colton","Luca","Landon","Hunter","Jonathan",
                "Santiago","Axel","Easton","Cooper","Jeremiah",
                "Angel","Roman","Connor","Jameson","Robert",
                "Greyson","Jordan","Ian","Carson","Jaxson",
                "Leonardo","Nicholas","Dominic","Austin","Everett",
                "Brooks","Xavier","Kai","Jose","Parker",
                "Adam","Jace","Wesley","Kayden","Silas"
        };
    private static string[] femaleNames = new string[100]
    {
                "Olivia","Emma","Ava","Charlotte","Sophia",
                "Amelia","Isabella","Mia","Evelyn","Harper",
                "Camila","Gianna","Abigail","Luna","Ella",
                "Elizabeth","Sofia","Emily","Avery","Mila",
                "Scarlett","Eleanor","Madison","Layla","Penelope",
                "Aria","Chloe","Grace","Ellie","Nora",
                "Hazel","Zoey","Riley","Victoria","Lily",
                "Aurora","Violet","Nova","Hannah","Emilia",
                "Zoe","Stella","Everly","Isla","Leah",
                "Lillian","Addison","Willow","Lucy","Paisley",
                "Natalie","Naomi","Eliana","Brooklyn","Elena",
                "Aubrey","Claire","Ivy","Kinsley","Audrey",
                "Maya","Genesis","Skylar","Bella","Aaliyah",
                "Madelyn","Savannah","Anna","Delilah","Serenity",
                "Caroline","Kennedy","Valentina","Ruby","Sophie",
                "Alice","Gabriella","Sadie","Ariana","Allison",
                "Hailey","Autumn","Nevaeh","Natalia","Quinn",
                "Josephine","Sarah","Cora","Emery","Samantha",
                "Piper","Leilani","Eva","Everleigh","Madeline",
                "Lydia","Jade","Peyton","Brielle","Adeline"
    };
    private static string[] godNames = new string[13]
    {
            "Zeus","Hera","Poseidon","Demeter",
            "Athena","Apollo","Artemis","Ares",
            "Aphrodite","Hephaestus","Hermes",
            "Hestia","Dionysus"
    };

    //Get random Polti`s situation
    public static int GetPoltiValue()
    {
        int _poltiValue = Random.Range(0, 36);
        return _poltiValue;
    }

    public static string getGender()
    {
        string gender = genders[Random.Range(0, 2)];
        return gender;
    }

    public static string getName(string gender)
    {
        string name;

        switch (gender)
        {
            case "m":
                name = maleNames[Random.Range(0, 100)];
                break;
            case "f":
                name = femaleNames[Random.Range(0, 100)];
                break;
            case "n":
                name = godNames[Random.Range(0, 13)];
                break;
            default:
                name = "DefaultName";
                break;
        }

        return name;
    }
}
