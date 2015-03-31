using UnityEngine;
using System.Collections;

public class MovCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
        startVec = Input.acceleration;
        camDist = Vector3.Distance(Vector3.zero, gameObject.transform.position);
	}

    float camDist;
    Vector3 startVec;
    Quaternion camRot = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));
	
	// Update is called once per frame
	void Update () {
        var acc = new Vector3(Input.acceleration.x, - Input.acceleration.z, Input.acceleration.y);
        acc.Normalize();
        gameObject.transform.position = Vector3.zero + (acc * camDist);    
        gameObject.transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform.position, camRot*acc);
                
        GameObject.FindGameObjectWithTag("Debug").GetComponent<UnityEngine.UI.Text>().text = acc.ToString()+ "\r\n"+  (camRot * acc).ToString();
	}
}
