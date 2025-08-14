using TMPro;
using UnityEngine;

public class Interactive : MonoBehaviour
{

    private TextMeshProUGUI tmp;
    [SerializeField] private Animal_Interactive animal_interacive;

    private void Start()
    {
        tmp = GetComponentInChildren<TextMeshProUGUI>();
        tmp.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerController2D>() != null)
        {
            tmp.gameObject.SetActive(true);
            tmp.text = animal_interacive.message;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        tmp.gameObject.SetActive(false);

    }
}
