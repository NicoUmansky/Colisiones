using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            //Destroy(gameObject);
            transform.position = new Vector3(0, 3, 0);
        }
    }
    void OnCollisionExit(Collision col2)
    {
        if (col2.gameObject.name == "Plane")
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}
