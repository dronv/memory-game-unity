using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    GameObject gameControl;
    public SpriteRenderer spriteRenderer;
    public Sprite[] cartoon_faces;
    public Sprite back;
    public int cartoon_index;
    public bool cardsMatched = false;
    public void OnMouseDown()
    {
        if (cardsMatched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (gameControl.GetComponent<GameManager>().checkTwoVisibleCards() == false)
                {
                    spriteRenderer.sprite = cartoon_faces[cartoon_index];
                    gameControl.GetComponent<GameManager>().GetVisibleCardIndex(cartoon_index);
                    cardsMatched = gameControl.GetComponent<GameManager>().CheckCardMatch();
                }
            }

            else
            {
                spriteRenderer.sprite = back;
                gameControl.GetComponent<GameManager>().RemoveVisibleCardIndex(cartoon_index);
            }
        }
    }
    private void Awake()
    {
        gameControl = GameObject.Find("GameManager");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
