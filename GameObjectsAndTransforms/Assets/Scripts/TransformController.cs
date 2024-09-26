using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    //testing
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, 3); transform.position = new Vector3(x, 0, 0);

    }
}
