
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
  
    // Update is called once per frame
    public int forwordforce =-1000;
    public int sideforces = -1000;
    void FixedUpdate()
    {
        rb.AddForce(forwordforce * Time.deltaTime, 0, 0);
           if(Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideforces * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sideforces * Time.deltaTime,ForceMode.VelocityChange);

        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-forwordforce * Time.deltaTime, 0, 0);
        }
    }
}
