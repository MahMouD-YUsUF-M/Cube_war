
using UnityEngine;
using UnityEngine.SceneManagement;
public class gammanger : MonoBehaviour
{
    bool end = false;
    public GameObject END;
    public void com()
    {
        END.SetActive(true);
    }
   public void  EndGame()
    {

        Invoke("Restart", 3f);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
