using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public GameManager instance;

    public List<Card> cards = new List<Card>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadCollectionScene()
    {
        SceneManager.LoadScene("CollectionManager");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
