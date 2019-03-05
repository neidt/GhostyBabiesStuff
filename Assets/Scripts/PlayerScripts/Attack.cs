using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float attackSpeed = .5f;
    public float damage = 1f;

    public GameObject hitbox;
    public Transform hitboxOrigin;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            AttackAttack();
        }
    }

    public void AttackAttack()
    {
        Destroy(GameObject.Instantiate(hitbox, hitboxOrigin.position, Quaternion.identity, transform.GetChild(0)), .4f);
    }
}
