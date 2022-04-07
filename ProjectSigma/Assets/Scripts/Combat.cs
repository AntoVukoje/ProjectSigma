using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public bool canAttack = true;
    public bool isAttacking = false;

    public GameObject attackRange;
    private GameObject attackRangeCopy;

    private GameObject playPos;

    public float cooldown = 0.3f;

    private void Start()
    {
        playPos = GameObject.Find("Player_body");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canAttack)
        {
            canAttack = false;
            isAttacking = true;
            attackRangeCopy = Instantiate(attackRange, new Vector3(playPos.transform.position.x + 0.7f, playPos.transform.position.y, playPos.transform.position.z - 0.7f), new Quaternion(playPos.transform.rotation.x, playPos.transform.rotation.y, playPos.transform.rotation.z, playPos.transform.rotation.w));
            StartCoroutine(resetAttack());
        }
    }

    IEnumerator resetAttack()
    {
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
        isAttacking = false;
        Destroy(attackRangeCopy);
    }

    
}
