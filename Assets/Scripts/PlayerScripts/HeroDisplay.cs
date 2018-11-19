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
    public Image attackImage;
    public Image armorImage;

    public void Update()
    {
        if (myHero.attack > 0)
        {
            attackImage.gameObject.SetActive(true);
        }
        else
        {
            attackImage.gameObject.SetActive(false);
        }

        if (myHero.armor > 0)
        {
            armorImage.gameObject.SetActive(true);
        }
        else
        {
            armorImage.gameObject.SetActive(false);
        }
    }

    public void HeroSetUp(Hero thisHero)
    {
        myHero = thisHero;

        HPText.text = myHero.health.ToString();
        armorText.text = myHero.armor.ToString();
        attackText.text = myHero.attack.ToString();

        heroImage.sprite = myHero.heroPortrait;
    }
}
