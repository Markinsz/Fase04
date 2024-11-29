using System.Collections;
using UnityEngine;

public class Esteira : MonoBehaviour
{
    private BoxCollider2D esteiraCollider;

    void Start()
    {
        esteiraCollider = GetComponent<BoxCollider2D>();
    }

    [System.Obsolete]
    private void Update()
    {
        PlayerController playerController = FindObjectOfType<PlayerController>();

        if (playerController.playerRigidBody ) {
        if (playerController != null)
        {
            GoBack(playerController.playerDirection);
        }
        else
        {
            Debug.LogWarning("PlayerController não encontrado");
        }
    }

        private void GoBack(Vector2 playerDirection)
    {
        while (playerDirection.x > -1 && playerDirection.x > 0)
        {
            playerDirection.x -= 1;
        }
    }
}
