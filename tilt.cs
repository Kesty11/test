using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 currentRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetAxis("Horizontal") > .2) && (currentRot.z <= 10 || currentRot.z >= 348))
        {
            transform.Rotate(0, 0, 1);
        }
        if ((Input.GetAxis("Horizontal") < -.2) && (currentRot.z >= 349 || currentRot.z <= 11))
        {
            transform.Rotate(0, 0, -1);
        }
        if ((Input.GetAxis("Vertical") > .2) && (currentRot.x <= 10 || currentRot.x >= 348))
        {
            transform.Rotate(1, 0, 0);
        }
        if ((Input.GetAxis("Vertical") < -.2) && (currentRot.x >= 349 || currentRot.x <= 11))
        {
            transform.Rotate(-1, 0, 0);

        }
    }
}
