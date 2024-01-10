using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the enemy === //
    public float speed;
    public float changeTime = 3.0f;
    // === Create a float variable for the change time of the enemy === //


    // === Create a Rigidbody2D variable for the enemy === //
    Rigidbody2D rigidbody2D;

    // === Create a float varaible for the timer of the enemy === //
    float timer;
    int direction = 1;

    // === Create an int varaible for the direction of the enemy and set it EQUAL to 1 === //
    
    
    // Start is called before the first frame update
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
    rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;

        // === Set the timer variable EQUAL to the change time variable below === //

    }

    void Update()
    {
        // === Set the timer variable to be MINUS EQUALS " -= " to the Time.deltaTime === //
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }


        // === Create an if-statement below that checks when the timer variable is LESS THAN 0 === //
        // === Inside the if-statement set the direction variable to be EQUAL to MINUS of the direction variable === //
        // === Also inside the if-statement, set the timer variable back EQUAL to the change time variabel === //
    
    
    void FixedUpdate()
    {
        // === Create a private Vector2 variable and set it EQUAL to your Rigidbody2D variable's .position === //
        Vector2 position = rigidbody2D.position;

        // === Get the x value of your Vector2 variable and set it EQUAL to itself MULTIPLIED by your speed variable MULTIPLIED by your direction variable MULTIPLIED by Time.deltaTime === //
        position.x = position.x + Time.deltaTime * speed * direction;

        // === Use the .MovePosition() method with your Rigidbody2D variable and put your Vector2 varaible name in between the " () " parentheses === //
        rigidbody2D.MovePosition(position);
    }
}
