using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
      public float moveSpeed;
      public Rigidbody2D rb2d;
      private Vector2 moveInput;
      public float CurrentHealth;
      public float MaxHealth = 10;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
      Movement();
      Shooting();
      Health();
    }

    public void Movement() 
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;
    }
    
    public void Shooting() 
    {
      
    }

    public void Health() 
    {
       
    }

     public void TakeDamage(int amount) 
     {
         CurrentHealth -= amount;
         if(CurrentHealth <= 0) {
            // Destroy(GameObject);
         }
     }
    


}
