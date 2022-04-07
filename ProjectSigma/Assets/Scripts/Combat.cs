using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public bool canAttack = true;

    public GameObject attackRange;
    private GameObject attackRangeCopy;

    private GameObject playPos;

    public float cooldown = 0.3f;
    public float animationDuration = 0.1f;

    private void Start()
    {
        playPos = GameObject.Find("Player_body");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canAttack)
        {
            canAttack = false;
            attackRangeCopy = Instantiate(attackRange, new Vector3(playPos.transform.right.x + playPos.transform.position.x, playPos.transform.position.y, playPos.transform.right.z + playPos.transform.position.z), new Quaternion(playPos.transform.rotation.x, playPos.transform.rotation.y, playPos.transform.rotation.z, playPos.transform.rotation.w));
            StartCoroutine(resetAttack());
        }
    }

    IEnumerator resetAttack()
    {
        StartCoroutine(stopAttack());
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    }

    IEnumerator stopAttack()
    {
        yield return new WaitForSeconds(animationDuration);
        Destroy(attackRangeCopy);
    }

    
}
