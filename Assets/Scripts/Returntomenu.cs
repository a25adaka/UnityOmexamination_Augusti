using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
