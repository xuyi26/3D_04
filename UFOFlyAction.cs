using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOFlyAction : SSAction {
    public float gravity = 9.8f;
    private float time;
    private Vector3 start_vector;
    private Vector3 gravity_vector = Vector3.zero;
    private Vector3 current_angle = Vector3.zero;

}
