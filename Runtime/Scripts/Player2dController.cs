using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;

public class Player2dController : MonoBehaviour
{
    [SerializeField]
    private TopDown2dCharacterController managedController;
    InputAction movementAction;
    // Start is called before the first frame update
    void Start()
    {
        movementAction = InputSystem.actions.FindAction("Move");
        Assert.IsNotNull(movementAction, "Move action not found");
    }

    // Update is called once per frame
    void Update()
    {
        managedController.movementVector = movementAction.ReadValue<Vector2>();
    }
}
