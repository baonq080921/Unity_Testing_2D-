using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI instance;
    [SerializeField] private TextMeshProUGUI tmp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    public void UpdateUI(int nums)
    {
        string message = nums.ToString();
        tmp.text = $"Score {message}";
        if (nums == 0)
            tmp.text = "You win";
    }
}
