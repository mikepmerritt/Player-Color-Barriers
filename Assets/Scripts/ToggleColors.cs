using UnityEngine;
using System;

public class ToggleColors : MonoBehaviour
{
    public Rigidbody2D rb;
    public static event Action changeColor;
    public StringVariable playerColor;
    public bool inWall = false;

    private void Start() {
        rb = GetComponent<Rigidbody2D>(); // get attached rigidbody
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && !inWall && changeColor != null) {
            // HINT: if using more than 2 colors, replace line 18 with a full if/else structure
            playerColor.value = playerColor.value == "red" ? "blue" : "red"; // if red, make blue; if blue, make red
            ToggleColors.changeColor.Invoke(); // trigger event if space is pressed, not in a wall, and event exists
        }
    }
    
    private void OnTriggerStay2D(Collider2D other) {
        inWall = true; // set wall status to make sure player can't swap when in a wall
    }

    private void OnTriggerExit2D(Collider2D other) {
        inWall = false; // reset wall status if not in wall anymore
    }
}