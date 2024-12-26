
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scot;

    // Update is called once per frame
    void Update()
    {
        float pos =-1* (player.position.x-119);
        scot.text =pos.ToString("0");
    }
}
