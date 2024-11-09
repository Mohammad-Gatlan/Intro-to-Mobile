using UnityEngine.SceneManagement;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    // Start is called before the first frame update
 private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextLevel % SceneManager.sceneCountInBuildSettings);
        }
    }
}
