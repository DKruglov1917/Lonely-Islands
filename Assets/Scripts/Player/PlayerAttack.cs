using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Camera cam;
    public GameObject hand, bloodParticle;
    public DamagePopup damagePopup;
    private Animator animator;
    private Weapon weapon;

    public float attackSpeed = 1;
    private bool canAttack;

    private void Start()
    {
        weapon = hand.GetComponentInChildren<Weapon>();
        animator = hand.GetComponent<Animator>();

        canAttack = true;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("AttackCoroutine");
        }
    }

    private void DoAttack()
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
                bloodParticleClone.transform.LookAt(hand.transform);
                Destroy(bloodParticleClone, 2);

                DamagePopup cloneDamagePopup = Instantiate(damagePopup, hit.point, Quaternion.identity);
                cloneDamagePopup.Setup(weapon.damage);
            }
        }
    }

    IEnumerator AttackCoroutine()
    {
        if (canAttack)
        {
            canAttack = false;
            DoAttack();
            yield return new WaitForSeconds(attackSpeed);
            canAttack = true;
        }
    }
}
