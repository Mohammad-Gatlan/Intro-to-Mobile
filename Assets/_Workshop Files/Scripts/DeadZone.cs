
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            int actualScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(actualScene);
        }
    }
}
