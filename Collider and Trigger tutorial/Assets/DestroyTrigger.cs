using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{

    /// when this object have trigger and
    /// then enter hit another gameobject
    /// with tag ball, will do something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            ///Do something
            transform.Translate(.5f, 0, 0);
        }
    }

    /// when this object have trigger and
    /// then exit after hit another gameobject
    /// with tag ball, will do something
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            ///Do something
            transform.Translate(.5f, 0, 0);
        }
    }

    /// when this object have trigger and
    /// then hit another gameobject
    /// with tag ball, will do something when
    /// still hit the another object with tag ball
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            ///Do something
            transform.Translate(.5f, 0, 0);
        }
    }
}
