using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    private Health health;
    private CapsuleCollider capsuleCollider;

    public string personage, type, gender, personageName;
    //create hostility parameter    

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
            personageName = personage;
        }

        // Debug.Log("So we have: " + personage + ", " + type + ", " + gender + ", " + personageName);
    }

    private void Start()
    {
        health = GetComponent<Health>();

        animator = transform.GetChild(0).GetComponentInChildren<Animator>();

        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    private void Update()
    {
        if (health.curHP <= 0 && animator.GetBool("dead") == false)
        {
            capsuleCollider.enabled = false;
            animator.SetBool("dead", true);
        }
    }
}
