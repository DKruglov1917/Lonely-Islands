using UnityEngine;

public class Character : MonoBehaviour
{
    public GroundItem pfGroundItem;
    public ItemDatabaseObject Database;

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
        if (health.dead && animator.GetBool("dead") == false)
        {
            capsuleCollider.enabled = false;
            animator.SetBool("dead", true);

            DropOnDeath();
        }
    }

    private void DropOnDeath() //relocate
    {
        GroundItem drop = Instantiate(pfGroundItem, transform.position, Quaternion.identity);
        int rnd = Random.Range(0, Database.ItemObjects.Length);
        drop.item = Database.ItemObjects[rnd];
        drop.name = "DropItem";
        //temp
        drop.transform.SetParent(GameObject.Find("Items").transform);
    }
}
