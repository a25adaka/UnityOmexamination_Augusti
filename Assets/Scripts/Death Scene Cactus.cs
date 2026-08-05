using UnityEngine;

public class DeathSceneCactus : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("DefeatCactus");
        }
    }
}

