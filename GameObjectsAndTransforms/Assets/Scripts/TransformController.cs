using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        var x = Mathf.PingPong(t: Time.time, 3);
        var p = new Vector3(x: 0, y: x, z: 0);
        transform.position = p;
    }
}
