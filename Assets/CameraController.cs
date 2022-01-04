using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject runner;
    private Vector3 offset;

    //float rOfff = .001f;


    void Start()
    {
        offset = transform.position - runner.transform.position;
    }

 //   //// Update is called once per frame
 //   void Update()
 //   {
 //transform.rotation = Quaternion.Lerp(transform.rotation, runner.transform.rotation, rOfff);
 //   }

    void LateUpdate()
    {
        transform.position = runner.transform.position + offset;
    }
}
