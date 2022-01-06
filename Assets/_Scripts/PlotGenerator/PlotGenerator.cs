using UnityEngine;

public class PlotGenerator : MonoBehaviour
{
    public Character characterPrefab;

    private void Start()
    {
        GeneratePlot();
    }

    private void GeneratePlot()
    {
        CharacterData.poltiValue = CharacterData.GetPoltiValue();

        CreateCharacters();

        StoryData.WriteStory(CharacterData.poltiValue); //make private

        QuestData.ChooseQuest();
    }

    private void CreateCharacters()
    {
        for (int i = 0; i < CharacterData.characters[CharacterData.poltiValue].Length; i++)
        {
            Character character;

            character = Instantiate(characterPrefab, new Vector3(i * 2.0F, 1, 0), Quaternion.Euler(0, 180, 0));

            character.CreateCharacter(i);

            character.transform.parent = gameObject.transform.GetChild(0);

            if (character.gender == "m")
                character.gameObject.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
            else if (character.gender == "f")
                character.gameObject.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);

            character.name = character.personageName;
        }
    }
}
