using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Text EnemyKillCounter;
    public int points;

    private void Update()
    {
        EnemyKillCounter.text = "Points: " + points;
    }

    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
