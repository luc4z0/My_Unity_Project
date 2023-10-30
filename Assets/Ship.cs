using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ship : MonoBehaviour
{
    public float ac;
    public float maxSpeed;
    private Vector3 velocity;
    private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.value, Random.value, 0.0f);
        ac = 0.0f;
        maxSpeed = 5;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update(){
        // update velocity
        UpdateSpeed();
        // update step
        UpdateStep();
          
    }
    // update accerlation
    public void UpdateAcceleration(float a){
        ac = a;
    }

    // update velocity
    private void UpdateSpeed(){
        // find accelation 
        Vector3 mousePos = Input.mousePosition;
        mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        mousePos.z = 0.0f;
        Vector3 accerlation = ac * (mousePos - transform.position).normalized;
        // update velocity
        if ((velocity + accerlation * Time.deltaTime).magnitude < maxSpeed){
            velocity += accerlation * Time.deltaTime;
        }
        
    }

    // update step
    private void UpdateStep() {
        transform.position += velocity * Time.deltaTime;
    }

}
