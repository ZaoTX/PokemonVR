using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public LineRenderer line;
    public GameObject head;
    public GameObject target;
    float dist=0;
    float t=0;
    // Start is called before the first frame update
    void Start()
    {
        //get head position
        //Vector3 headPos = new Vector3(head.transform.position.x, head.transform.position.y, head.transform.position.z);
        line.SetPosition(0, head.transform.position);
        Debug.Log(head.transform.position);
        dist = Vector3.Distance(head.transform.position,target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (t < dist) {
            t += 0.01f / 1;
            float x = Mathf.Lerp(0, dist, t);

            Vector3 pointA = head.transform.position;
            Vector3 pointB = target.transform.position;
            Vector3 pointAlongline = x * Vector3.Normalize(pointB - pointA) + pointA;
            line.SetPosition(1, pointAlongline);

        }
        
    }
}
