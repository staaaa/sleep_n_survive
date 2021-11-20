using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform trans;
    public Transform cameraa;

    void Update()
    {
        if(static_walk.can_walk == true)
        {
            if(trans.transform.position.x - cameraa.transform.position.x < -2.5f)
            {
                cameraa.transform.position = new Vector3(cameraa.transform.position.x + (trans.transform.position.x - cameraa.transform.position.x) + 2.5f, cameraa.transform.position.y, -10f);
            }
            if (trans.transform.position.x - cameraa.transform.position.x > 2.5f)
            {
                cameraa.transform.position = new Vector3(cameraa.transform.position.x + (trans.transform.position.x - cameraa.transform.position.x) - 2.5f, cameraa.transform.position.y, -10f);
            }
            if (trans.transform.position.y - cameraa.transform.position.y < -1.5f)
            {
                cameraa.transform.position = new Vector3(cameraa.transform.position.x, cameraa.transform.position.y + (trans.transform.position.y - cameraa.transform.position.y) + 1.5f, -10f);
            }
            if (trans.transform.position.y - cameraa.transform.position.y > 1.5f)
            {
                cameraa.transform.position = new Vector3(cameraa.transform.position.x, cameraa.transform.position.y + (trans.transform.position.y - cameraa.transform.position.y) - 1.5f, -10f);
            }
        }
    }
}
