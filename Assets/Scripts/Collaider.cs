
using UnityEngine;
using UnityEngine.UI;
// This Assaiment for Capital Rush,
//Date=02/03/2023.
public class Collaider : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer colorchanger,Child;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Small_1")
        {
           Destroy(collision.gameObject);
            Debug.Log("It;s collaide with " + gameObject.name);

        }
    }
    private void OnMouseDown()
    {
        this.GetComponent<SpriteRenderer>().color=Color.red;
        Child.enabled = true;
        colorchanger.color = Color.red;
    }
}
