using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;


    public int floaterCount = 1;
    public float waterDrag = 0.99f;
    public float waterAngularDrag = 0.5f;

    private void FixedUpdate()
    {
        //Applys gravity at the floater's position. Adds 14 times the gravity! XD
        //Done outside the If Statement, due to gravity always being applied, regardless of where the floater is.
        rigidbody.AddForceAtPosition(Physics.gravity / floaterCount, transform.position, ForceMode.Acceleration); 

        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x); //Singleton used to check if Floater is under the water waves.

        #region Check if the floater object is underwater (waveHeight), in order to add buoyency

        if (transform.position.y < waveHeight)
        {

            //This float aproximated a % of how much of the object is submerged, which affects how strong the buoyency force will be.
            //The reason why we use Clamp01 is cuz once the floater is submerged, the buoyency stays the same, regardless of how far underwater the object is.

            float displacementMultiplier = Mathf.Clamp01((waveHeight - transform.position.y) / depthBeforeSubmerged) * displacementAmount;

            //This adds the upwards force, based on the result of the dispacement Multiplier.
            //The AddForceAtPosition is to use the multiple floater objects that surround the boat.
            rigidbody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position, ForceMode.Acceleration);
            
            //The flollowing statements are to add drag physics, to prevent bounciness.
            rigidbody.AddForce(displacementMultiplier * -rigidbody.velocity * waterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            rigidbody.AddTorque(displacementMultiplier * -rigidbody.angularVelocity * waterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        #endregion
    }
}
