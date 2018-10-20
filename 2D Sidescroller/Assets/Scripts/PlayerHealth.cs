using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool inDeadzone;

    public float playerHealth;


    IEnumerator DoDeadzoneDamage(float damageDuration, int damageCount, float damageAmount)
    {
        inDeadzone = true;
        int currentCount = 0;
        while(currentCount < damageCount)
        {
            playerHealth -= damageAmount;
            yield return new WaitForSeconds(damageDuration);
            currentCount++;
        }
        inDeadzone = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Deadzone" && inDeadzone)
        {
            StartCoroutine(DoDeadzoneDamage(1.0f, 5, 1.0f));
        }
    }
}
