using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(gameObject.transform.rotation.x+1, gameObject.transform.rotation.y, gameObject.transform.rotation.z +1));
    }
}
