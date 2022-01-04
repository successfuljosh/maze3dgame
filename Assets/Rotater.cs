using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    //new object to replace the old with
    //public GameObject CollectCapsule;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }


    private void OnCollisionStay(Collision collision)
    {
        //to replace the object with another
        //  Instantiate(CollectCapsule, transform.position, transform.rotation);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        Destroy(gameObject, audio.clip.length);
   
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy1");
        KeepScore.Score += 100;
    }
}
