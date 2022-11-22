
using UnityEngine;
public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpForce;  
    private int nbSauts;
    [SerializeField] private int nbMaxSauts;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animation Animation;
    [SerializeField] private bool isGrounded;
    [SerializeField] private int Ground = 3;

//Method of the jumping action
public void Jumping()
//Jump counter and limiter  
    {
        if(nbSauts >= nbMaxSauts)
        { 
            return;
        }
            rb.AddForce(transform.up * jumpForce);
            nbSauts++;        
    }

// reboot of jump counter    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer==Ground)
        {
            nbSauts = 0;
        }
    }
   
  

}
