using UnityEngine;
using UnityEngine.UI;

public class HeroDisplay : MonoBehaviour
{
    [HideInInspector]
    public Hero myHero;

    public Text HPText;
    public Text armorText;
    public Text attackText;

    public Image heroImage;

    public void HeroSetUp(Hero thisHero)
    {
        myHero = thisHero;

        HPText.text = myHero.health.ToString();
        armorText.text = myHero.armor.ToString();
        attackText.text = myHero.attack.ToString();

        heroImage.sprite = myHero.heroPortrait;
    }
}
