using UnityEngine;
using UnityEngine.UI;

public class GameLevelManager : MonoBehaviour
{
    public Hero playerHero;
    public Hero enemyHero;

    public GameObject heroPrefab;

    public Transform playerPortraitSpawn;
    public Transform enemyPortraitSpawn;

    public int currentTurn = 0;
    public int currentMaxMana = 1;
    public int activeMana = 1;
    public GameObject[] manaCrystals = new GameObject[20];

    public Button endTurnButton;
    public Button startTurnButton;

    public Text turnText;

    void Start()
    {
        PlayerSetUp();
        EnemySetUp();

        OnTurnStart();
        startTurnButton.gameObject.SetActive(false);
    }

    void Update()
    {
        CurrentMana();

        turnText.text = currentTurn.ToString();
    }

    void CurrentMana()
    {
        for (int i = 0; i < manaCrystals.Length; i++)
        {
            if (i < activeMana)
            {
                manaCrystals[i].SetActive(true);
            }
            else
            {
                manaCrystals[i].SetActive(false);
            }
        }
    }

    void PlayerSetUp()
    {
        GameObject go = Instantiate(heroPrefab, new Vector3(playerPortraitSpawn.position.x, playerPortraitSpawn.position.y, playerPortraitSpawn.position.z), Quaternion.identity);
        HeroDisplay display = go.GetComponent<HeroDisplay>();
        display.HeroSetUp(playerHero);
    }

    void EnemySetUp()
    {
        GameObject go = Instantiate(heroPrefab, new Vector3(enemyPortraitSpawn.position.x, enemyPortraitSpawn.position.y, enemyPortraitSpawn.position.z), Quaternion.identity);
        HeroDisplay display = go.GetComponent<HeroDisplay>();
        display.HeroSetUp(enemyHero);
    }

    public void OnTurnStart()
    {
        currentTurn++;

        endTurnButton.gameObject.SetActive(true);
        startTurnButton.gameObject.SetActive(false);

        activeMana = currentMaxMana;
    }

    public void OnTurnEnd()
    {
        startTurnButton.gameObject.SetActive(true);
        endTurnButton.gameObject.SetActive(false);
        currentMaxMana++;
    }
}
