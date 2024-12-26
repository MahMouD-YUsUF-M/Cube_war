
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENGA : MonoBehaviour
{
    public gammanger gm;

    private void OnTriggerEnter()
    {
        gm.com();
    }
}
