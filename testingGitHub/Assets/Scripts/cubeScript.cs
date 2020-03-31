using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    // Declaring our cube object so we can work control it through code.
    public GameObject cube;

    // Adding [Range(min, max)] before the public float creates a slider for us to select a value in the editor.
    [Range(1, 2)] public float speed = 1;

    // Declaring our KeyCodes as public so we can easily assign a keyboard key in the Inspector Window.
    // Instead of hard-coding which button completes an input, we create a variable to use regardless of which keyboard key is selected.
    public KeyCode spinLeft;
    public KeyCode spinRight;
    public KeyCode spinUp;
    public KeyCode spinDown;
    public KeyCode tiltLeft;
    public KeyCode tiltRight;


    // Creating a float value for each of the axis to clean up the code, this also makes manipulating the values easier.
    float xRotation;
    float yRotation;
    float zRotation;


    // The Update function is called once per frame.
    void Update()
    {
        // Calling our SpinDirection method to ensure it is updated as soon as th ecorresponding button is pressed.
        SpinDirection();

        // cube is the variable of type GameObject which tells Unity to do a certain action with a certain object.
        // Here we tell Unity to use the cube, and to set its rotation equal to our float variables that we declared earlier. We accomplish this by using the .transform.Rotate(x,y,z); methid which is a built in Unity function.
        cube.transform.Rotate(xRotation, yRotation, zRotation);
    }


    // Creating the SpinDirection function to tell our 'cube' object which direction to rotate.
    void SpinDirection()
    {
        // This statement sets the yRotation variable equal to our speed variable.
        // Here we use the spinLeft variable to read if the specified key had been pressed.
        if (Input.GetKeyDown(spinLeft))
        {
            yRotation = speed;
        }

        // This statement sets the yRotation variable equal to the invert of our speed variable, allowing for th eobject to move in the opposite direction.
        // Here we use the spinRight variable to read if the specified key had been pressed.
        if (Input.GetKeyDown(spinRight))
        {
            yRotation = -speed;
        }

        // This statement sets the xRotation variable equal to our speed variable.
        // Here we use the spinUp variable to read if the specified key had been pressed.
        if (Input.GetKeyDown(spinUp))
        {
            xRotation = speed;
        }

        // This statement sets the xRotation variable equal to the invert of our speed variable, allowing for th eobject to move in the opposite direction.
        // Here we use the spinDown variable to read if the specified key had been pressed.
        if (Input.GetKeyDown(spinDown))
        {
            xRotation = -speed;
        }

        // This statement sets the zRotation variable equal to our speed variable.
        // Here we use the tiltLeft variable to read if the specified key had been pressed.
        if (Input.GetKeyDown(tiltLeft))
        {
            zRotation = speed;
        }

        // This statement sets the zRotation variable equal to the invert of our speed variable, allowing for th eobject to move in the opposite direction.
        // Here we use the tiltRight variable to read if the specified key had been pressed.
        if (Input.GetKeyDown(tiltRight))
        {
            zRotation = -speed;
        }
    }
}
