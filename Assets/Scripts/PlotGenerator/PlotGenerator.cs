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

            character = Instantiate(characterPrefab, new Vector3(i * 2.0F, 1, 0), Quaternion.identity);

            if (character.type != "Fact")
                character.CreateCharacter(i);

            character.name = character.personageName;
        }
    }
}
