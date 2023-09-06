using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Color red, blue; // add more colors if needed
    public StringVariable playerColor;
    public SpriteRenderer render;

    private void Start() {
        ChangePlayerColor();
        ToggleColors.changeColor += ChangePlayerColor; // subscribe wall color update to event
    }

    private void ChangePlayerColor() {
        if(playerColor.value == "red") {
            render.color = red; // if red, make red
        }
        else {
            render.color = blue; // if not red, make blue; add more cases if more colors are used
        }
    }
}