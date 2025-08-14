using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadSceneByIndex : MonoBehaviour
{
    [SerializeField] private GameObject nameInputPanel;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI tmp;

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void EnterName()
    {
        if (nameInputPanel != null)
        {
            nameInputPanel.SetActive(true);
            inputField.text = "";
            inputField.ActivateInputField(); // Đảm bảo ô nhập được focus ngay
        }
    }

    public void ConfirmNameAndStart()
    {
        string playerName = inputField.text;
        Debug.Log("Tên người chơi: " + playerName);
        tmp.text = playerName;

        // Ẩn panel sau khi nhập
        //nameInputPanel.SetActive(false);

        // Nếu muốn load scene ngay:
        // SceneManager.LoadScene(1);
    }
}
