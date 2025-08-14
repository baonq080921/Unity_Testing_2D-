using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] Camera mainCamera;
    [SerializeField] Camera secondayCamera;
    [SerializeField] private bool isFirstPerson;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.enabled = true;
        secondayCamera.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.V))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondayCamera.enabled = !secondayCamera.enabled;
        }
        
    }
}
