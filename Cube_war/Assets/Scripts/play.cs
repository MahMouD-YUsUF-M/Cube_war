
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public void Startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    // Update is called once per frame

}
