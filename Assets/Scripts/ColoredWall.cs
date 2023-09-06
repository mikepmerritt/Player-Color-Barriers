using UnityEngine;

public class ColoredWall : MonoBehaviour
{
    public string wallColor;
    public StringVariable playerColor;
    public Collider2D wallCollider;

    private void Start() {
        ChangeWallCollider();
        ToggleColors.changeColor += ChangeWallCollider; // subscribe wall color update to event
    }

    private void ChangeWallCollider() {
        if(wallColor == playerColor.value) {
            wallCollider.isTrigger = true; // if same color, make trigger so it is passable
        }
        else {
            wallCollider.isTrigger = false; // if different color, make collider so it blocks
        }
    }
}
