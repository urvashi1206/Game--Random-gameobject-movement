using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	/// <summary>
    /// Use this for initialization
    /// </summary>
	void Start()
    {
        // get the teddy bear moving
        const float MinMag = 3f;
        const float MaxMag = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinMag, MaxMag);
        GetComponent<Rigidbody2D>().AddForce(
            magnitude*direction ,
            ForceMode2D.Impulse);
    }
	
}