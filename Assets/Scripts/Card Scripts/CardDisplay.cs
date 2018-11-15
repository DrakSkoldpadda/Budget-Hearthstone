using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [HideInInspector]
    public Card card;

    [Header("Card Information")]
    public Text nameText;
    public Text descriptionText;

    [Header("Card Attributes")]
    public Text manaCostText;
    public Text attackText;
    public Text HPText;
    public Text typeText;

    [Header("Card Images")]
    public Image cardImage;
    public Image attackImage;
    public Image HPImage;

    public void CardSetUp(Card thisCard)
    {
        card = thisCard;

        nameText.text = card.name;
        descriptionText.text = card.description;
        typeText.text = card.cardType;

        manaCostText.text = card.manaCost.ToString();

        cardImage.sprite = card.cardSprite;

        if (card.isMinion)
        {
            attackText.text = card.attack.ToString();
            HPText.text = card.hitPoints.ToString();

            attackImage.gameObject.SetActive(true);
            HPImage.gameObject.SetActive(true);
        }
        else
        {
            attackImage.gameObject.SetActive(false);
            HPImage.gameObject.SetActive(false);
        }
    }
}