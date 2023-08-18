using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesMove : MonoBehaviour
{
    int[] posX = new int[] { 0, -18, -36, -54 };
    int idx = 0;
public AudioSource[] audio;
    // Update is called once per frame
	void Start()
	{
		audio[idx].Play();
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // Changed from GetKeyUp to GetKeyDown
        {
            if (idx < posX.Length - 1)
            {
                idx++;
				audio[idx].Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) // Changed from GetKeyUp to GetKeyDown
        {
            if (idx > 0)
            {
                idx--;
				audio[idx].Play();
            }
        }
        transform.position = Vector3.MoveTowards(transform.position,
            new Vector3(posX[idx], transform.position.y, transform.position.z), 50 * Time.deltaTime);
    }
}
