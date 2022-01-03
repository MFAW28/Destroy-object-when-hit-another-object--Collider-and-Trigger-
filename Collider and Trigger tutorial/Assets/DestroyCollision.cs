using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollision : MonoBehaviour
{
    /// when this object have collision (without trigger) and then hit another gameobject
    /// with tag ball, will do something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            ///Do something
            Destroy(gameObject); 
        }        
    }
}
