using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Camera cam;
    public GameObject hand, bloodParticle;
    public DamagePopup damagePopup;
    private Animator animator;
    private Weapon weapon;

    public float attackSpeed = 1;
    private float timer;

    private void Start()
    {
        weapon = hand.GetComponentInChildren<Weapon>();
        animator = hand.GetComponent<Animator>();

        timer = attackSpeed;
    }

    private void Update()
    {
        DoAttack();
    }

    private void DoAttack()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timer > attackSpeed)
        {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            animator.SetTrigger("attack");

            if (Physics.Raycast(ray, out hit, weapon.range))
            {
                if (hit.collider.tag == "Character")
                {
                    Health health = hit.collider.GetComponent<Health>();
                    health.TakeDamage(weapon.damage);

                    GameObject bloodParticleClone = Instantiate(bloodParticle, hit.point, Quaternion.identity);
                    bloodParticleClone.transform.parent = hit.transform;
                    bloodParticleClone.transform.LookAt(hand.transform);
                    Destroy(bloodParticleClone, 2);

                    DamagePopup cloneDamagePopup = Instantiate(damagePopup, hit.point, Quaternion.identity);
                    cloneDamagePopup.transform.parent = hit.transform;
                    cloneDamagePopup.Setup(weapon.damage);
                }
            }

            timer = 0;
        }
    }

    // private async void Attack()
    // {
    //     DoAttack();
    //     await Task.Delay((int)attackSpeed * 1000);
    //     print("delayed");
    // }
}
