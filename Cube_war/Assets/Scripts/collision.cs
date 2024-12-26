
using UnityEngine;

public class collision : MonoBehaviour
{
    public playermove pl;
   void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Opstcale")
        {
            pl.enabled = false;
            FindObjectOfType<gammanger>().EndGame();
        }
    }
   
}