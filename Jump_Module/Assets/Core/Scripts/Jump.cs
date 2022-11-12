using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jump : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;  
    private int nbSauts;
    [SerializeField]
    private int nbMaxSauts;
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Animation Animation;
    [SerializeField]
    private bool isGrounded;
    [SerializeField]
    private bool jump;
    [SerializeField]
    private int Ground = 3;

//Ground check, permit to know if we jumping or not
void Grounded()
    {
        if(isGrounded == true)
        {
            nbMaxSauts = 0 ;
        }
    }
//Method of the jumping action
void Jumping()
// Jump counter and limiter  
    {
        if(nbSauts >= nbMaxSauts)
        { 
            return;
        }
// Input used to do the jump                
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
            jump = true;
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
// called of Jump fonction    
    private void Update()
    {
        Jumping();
    }

}
