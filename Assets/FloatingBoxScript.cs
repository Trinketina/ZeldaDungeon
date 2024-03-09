using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBoxScript : MonoBehaviour
{
    public Rigidbody rb;
    public int sinkSpeed;
    public int riseSpeed;
    public Transform futureParent;

    public bool hasParent;
    private bool collided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y >= 0 && !collided)
        {
            rb.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasParent)
        {
            Debug.Log("sinking");
            rb.velocity = Vector3.down * sinkSpeed;
            collided = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasParent)
        {
            rb.velocity = Vector3.up * riseSpeed;
            Debug.Log("rising");
            collided = false;
        }
    }
    public void UpdateParent() 
    //for the obstructed blocks, once unobstructed the parent can be updated to the acid so they float properly
    {
        this.transform.SetParent(futureParent);
        hasParent = true;
        Debug.Log("has parent");
    }
}
