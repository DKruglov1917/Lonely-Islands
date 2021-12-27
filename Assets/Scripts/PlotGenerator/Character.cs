using UnityEngine;

public class Character : MonoBehaviour
{

    public string personage, type, gender, personageName;

    public void CreateCharacter(int number)
    {
        personage = CharacterData.characters[CharacterData.poltiValue][number];
        type = CharacterData.TypeOfCharacterDictionary[CharacterData.characters[CharacterData.poltiValue][number]];

        if (type != "Fact")
        {
            gender = CharacterData.getGender();
            personageName = CharacterData.getName(gender);
        }
        else
        {
            gender = "no gender";
            personageName = "no name";
        }

        Debug.Log("So we have: " + personage + ", " + type + ", " + gender + ", " + personageName);
    }
}
