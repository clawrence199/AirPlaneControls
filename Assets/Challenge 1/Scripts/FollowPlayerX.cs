using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject camPos;
    public GameObject plane;
    public GameObject lookAt;
    private Vector3 offset = new Vector3(0, 0, -10);
    public Transform target; 

    // Start is called before the first frame update
    void Start()
    {
        target = lookAt.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(camPos.transform.position, plane.transform.rotation);
       // transform.LookAt(target);
       /* transform.position = plane.transform.position + offset;
        transform.rotation = plane.transform.rotation;*/
    }
}
