using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown2dCharacterController: MonoBehaviour
{
    public Transform targetTransform;
    public Vector2 movementVector;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movementVector != Vector2.zero)
        {
            targetTransform.position += new Vector3(movementVector.x, movementVector.y, 0) * Time.deltaTime;
        }
    }
}
