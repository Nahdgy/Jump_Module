
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
void Jumping()
//Jump counter and limiter  
    {
        if(nbSauts >= nbMaxSauts)
        { 
            return;
        }
// Input used to do the jump                
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
            nbSauts++;
        }            
    }
// reboot of jump counter    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer==Ground)
        {
            nbSauts = 0;
        }
    }
// call of Jump fonction    
    private void Update()
    {
        Jumping();
    }

}
