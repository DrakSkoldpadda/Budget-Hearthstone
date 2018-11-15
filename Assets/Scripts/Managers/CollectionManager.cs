using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionManager : MonoBehaviour
{
    public GameManager instance;
    public GameObject cardPrefab;

    private int cardDisplayPosition = 0;

    void Awake()
    {
        instance = FindObjectOfType<GameManager>();

        instance.cards.Sort();
    }

    void Start()
    {
        int currentSpawn = 0;
        float xPos = 0f;
        float yPos = 2f;
        
        for (int i = 0; i < 21; i++)
        {
            foreach (Card card in instance.cards)
            {
                if (card.manaCost == i)
                {
                    switch (cardDisplayPosition)
                    {
                        case 0:
                            xPos = -4.5f;
                            break;
                        case 1:
                            xPos = -1.5f;
                            break;
                        case 2:
                            xPos = 1.5f;
                            break;
                        case 4:
                            xPos = 4.5f;
                            break;

                        default:
                            break;
                    }
                    cardDisplayPosition++;

                    if (cardDisplayPosition > 3)
                    {
                        cardDisplayPosition = 0;
                    }

                    GameObject go = Instantiate(cardPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
                    CardDisplay display = go.GetComponent<CardDisplay>();
                    display.CardSetUp(card);

                    currentSpawn++;

                    if (currentSpawn > 3)
                    {
                        yPos -= 4f;
                        currentSpawn = 0;
                    }
                }
            }
        }
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
