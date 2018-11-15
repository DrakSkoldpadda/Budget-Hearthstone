using UnityEngine;

public class CardHover : MonoBehaviour
{
    private Vector3 startPos;

    void OnMouseEnter()
    {
        startPos = transform.position;
        iTween.MoveTo(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z - 3), 0.01f);
    }

    void OnMouseExit()
    {
        iTween.MoveTo(gameObject, new Vector3(startPos.x, startPos.y, 0), 0.5f);
    }
}
