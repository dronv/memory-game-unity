using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    GameObject mainCard;
    GameObject gameStatus;
    public bool gameOver = false;
    List<int> cartoon_faces_indexes = new List<int> {0, 1, 2, 3, 4, 5, 6, 7,0, 1, 2, 3, 4, 5, 6, 7};
    public static System.Random random = new System.Random();
    public int shuffle = 0;
    GameObject tempCard;
    int[] visibleCartoonFace = { -1, -2 };
    void Start()
    {
        int original_length = cartoon_faces_indexes.Count;
        float xPosition = -6.48f;
        float yPosition = 3.18f;
        for(int i = 0; i < 15; i++)
        {
            shuffle = random.Next(1, (cartoon_faces_indexes.Count));
            tempCard = Instantiate(mainCard, new Vector3(
                xPosition, yPosition, 0),
                Quaternion.identity);
            tempCard.GetComponent<Card>().cartoon_index = cartoon_faces_indexes[shuffle];
            cartoon_faces_indexes.Remove(cartoon_faces_indexes[shuffle]);
            xPosition = xPosition + 4;
            if(i == 2)
            {
                xPosition = -10.48f;
                yPosition = 0.82f;
            }
            if (i == 6)
            {
                xPosition = -10.48f;
                yPosition = -1.53f;
            }
            if (i == 10)
            {
                xPosition = -10.48f;
                yPosition = -3.9f;
            }
        }
        mainCard.GetComponent<Card>().cartoon_index = cartoon_faces_indexes[0];
    }

    public bool checkTwoVisibleCards()
    {
        bool twocardsVisible = false;
        if(visibleCartoonFace[0] >= 0 && visibleCartoonFace[1] >= 0)
        {
            twocardsVisible = true;
        }
        return twocardsVisible;
    }
    
    public void GetVisibleCardIndex(int index)
    {
        if(visibleCartoonFace[0] == -1)
        {
            visibleCartoonFace[0] = index;
        }
        else if(visibleCartoonFace[1] == -2)
        {
            visibleCartoonFace[1] = index;
        }
    }

    public void RemoveVisibleCardIndex(int index)
    {
        if (visibleCartoonFace[0] == index)
        {
            visibleCartoonFace[0] = -1;
        }
        else if (visibleCartoonFace[1] == index)
        {
            visibleCartoonFace[1] = -2;
        }
    }

    public bool CheckCardMatch()
    {
        bool success = false;
        if(visibleCartoonFace[0] == visibleCartoonFace[1])
        {
            visibleCartoonFace[0] = -1;
            visibleCartoonFace[1] = -2;
            success = true;
        }
        return success;
    }

    public void gameOverState(bool isGameOver)
    {
        gameStatus.GetComponent<GameOverController>().ShowGameOver();
    }
    void Awake()
    {   
        mainCard = GameObject.Find("mainCard");
    }
}
