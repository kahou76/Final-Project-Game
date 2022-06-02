using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotHealth : MonoBehaviour
{
    [SerializeField] private int health;

    public int MAX_HEALTH = 100;
    // public BloodBar bloodBar;

    // Start is called before the first frame update
    void Start()
    {
        // health -= 20;
        //Debug.Log("Current Experience " + experience); // Added so we stop getting the warning anymore
        health = MAX_HEALTH;
        // bloodBar.SetMaxHealth(MAX_HEALTH);
    }

    // Update is called once per frame

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    // Added for Visual Indicators
    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Damage(int amount){

        if(amount <0){
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage");
        }
        this.health -= amount;

        StartCoroutine(VisualIndicator(Color.red)); // Added for Visual Indicators

        if(health <= 0){
            Die();
        }


    }
    // }

    private void Die(){
        Debug.Log("DEAD!!");
        Health.scoreValue += 10;
        Destroy(gameObject);
    }
}