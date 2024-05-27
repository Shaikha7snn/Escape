using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class EnableLightOnDetect : Action
{
    public SharedGameObject cameraObject;
    public Light cameraLight;
    public float detectionRange;
    public LayerMask detectionLayer;

    public override void OnStart()
    {
        cameraLight = cameraObject.Value.GetComponentInChildren<Light>();
        // Enable the light when the task starts
        cameraLight.enabled = true;
    }

    public override TaskStatus OnUpdate()
    {
        RaycastHit hit;
        // Perform a raycast to detect objects
        if (Physics.Raycast(cameraObject.Value.transform.position, cameraObject.Value.transform.forward, out hit, detectionRange, detectionLayer))
        {
            // Object detected, return success
            return TaskStatus.Success;
        }
        // No object detected, return failure
        return TaskStatus.Failure;
    }
}
