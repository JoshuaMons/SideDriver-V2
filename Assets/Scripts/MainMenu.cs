using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om scenes te laden

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Vervang met de naam van je speelscene
    }

    public void ExitGame()
    {
        Application.Quit(); // Sluit de game (werkt niet in de editor)
        Debug.Log("Game sluit af!"); // Alleen zichtbaar in de editor
    }
}
