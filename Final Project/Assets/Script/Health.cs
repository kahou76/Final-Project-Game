using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;

    // public int mana = 50;
    // [SerializeField] private int experience = 42;

    // Start is called before the first frame update
    // void Start()
    // {
    //     // health -= 20;
    //     Debug.Log("Current Experience " + experience); // Added so we stop getting the warning anymore
    // }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     health -= 20;
        //     if (health <= 0)
        //     {
        //         Debug.Log("Lol, you died. Press F to pay respect!");
        //     }
        // }

        // if (health <= 0 && Input.GetKeyDown(KeyCode.F))
        // {
        //     Debug.Log("RESPECT");
        // }


        if(Input.GetKeyDown(KeyCode.H)){
            // Heal(10);
        }

        if(Input.GetKeyDown(KeyCode.K)){
            // Damage(10);
        }
    }

    public void Damage(int amount){

        if(amount <0){
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage");
        }
        this.health -= amount;

        if(health <= 0){
            Die();
        }


    }

    public void Heal(int amount){
        if(amount <0){
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool WouldBeOverMAXHEALTH = health + amount > MAX_HEALTH;

        if(WouldBeOverMAXHEALTH){
            this.health = MAX_HEALTH;
        }else{
            this.health += amount;
        }

        
    }

    private void Die(){
        Debug.Log("DEAD!!");
        Destroy(gameObject);
    }
}