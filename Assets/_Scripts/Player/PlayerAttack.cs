using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private PlayerSound sound;
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
                    bloodParticleClone.transform.SetParent(hit.transform);
                    bloodParticleClone.transform.LookAt(hand.transform);
                    Destroy(bloodParticleClone, 2);

                    DamagePopup cloneDamagePopup = Instantiate(damagePopup, hit.point, Quaternion.identity);
                    cloneDamagePopup.transform.SetParent(hit.transform);
                    cloneDamagePopup.Setup(weapon.damage);
                }
                else if (hit.collider.tag == "Radio")
                {
                    hit.transform.GetComponent<Radio>().ChooseSong();
                    hit.transform.GetComponent<ObjectShake>().Shake();
                }

                sound.HitSound();
            }

            timer = 0;
        }
    }
}
