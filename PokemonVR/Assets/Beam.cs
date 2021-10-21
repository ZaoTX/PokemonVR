using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public LineRenderer line;
    public GameObject ParticleSystem;
    float dist=0;
    float t=0;
    // Start is called before the first frame update
    void Start()
    {
        //get head position
        //Vector3 headPos = new Vector3(head.transform.position.x, head.transform.position.y, head.transform.position.z);
        Vector3 pointA = new Vector3(0,0,1);
        Vector3 pointB = new Vector3(0, 0, 0);
        //line.SetPosition(0, head.transform.position);
        //Debug.Log(head.transform.position);
        dist = Vector3.Distance(pointA, pointB);
        //Destroy(line.gameObject, 8);
        //Destroy(ParticleSystem, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if (t < dist) {
            t += 0.005f / 1;
            float x = Mathf.Lerp(0, dist, t);

            Vector3 pointA = new Vector3(0, 0, 0);
            Vector3 pointB = new Vector3(0, 0, 1);
            Vector3 pointAlongline = x * Vector3.Normalize(pointB - pointA) + pointA;
            line.SetPosition(1, pointAlongline);
            

        }
        else {
            line.gameObject.SetActive(false);
            ParticleSystem.SetActive(false);
        }
        

    }
}
