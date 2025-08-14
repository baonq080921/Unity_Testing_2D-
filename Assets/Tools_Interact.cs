using UnityEngine;

public class Tools_Interact : MonoBehaviour
{
    private SpriteRenderer sprite_renderer;
    private Color originalColor;

    private void Start()
    {
        sprite_renderer = GetComponentInChildren<SpriteRenderer>();
        originalColor = sprite_renderer.color; // lưu màu ban đầu
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            sprite_renderer.color = Color.red;
            Debug.Log("Hello! Player touched tool.");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            sprite_renderer.color = originalColor; // khôi phục màu ban đầu
        }
    }
}
