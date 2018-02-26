using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerscript : MonoBehaviour {

	private Rigidbody rb;

	bool movingForward = false;
	bool movingBack = false;
	bool movingLeft = false;
	bool movingRight = false;

	float speed = 7f;
	private Vector3 movement;

	private float moveHorizontal;
	private float moveVertical;

	public GameObject c1;
	public GameObject cs1;
	public GameObject d1;
	public GameObject ds1;
	public GameObject e1;
	public GameObject f1;
	public GameObject fs1;
	public GameObject g1;
	public GameObject gs1;
	public GameObject a1;
	public GameObject as1;
	public GameObject b1;
	public GameObject c21;
	public GameObject c22;
	public GameObject cs2;
	public GameObject d2;
	public GameObject ds2;
	public GameObject e2;
	public GameObject f2;
	public GameObject fs2;
	public GameObject g2;
	public GameObject gs2;
	public GameObject a2;
	public GameObject as2;
	public GameObject b2;
	public GameObject c3;


	public bool jumping;

	public bool canvasCheck;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");
	}
	
	// Update is called once per frame
	void Update () {

		movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = 25f;
		} 
		else {
			speed = 10f;
		}


		//transform.rotation = Quaternion.Slerp(new Quaternion(0f,transform.rotation.y,0f,0f), new Quaternion(0f,Camera.main.transform.rotation.y,0f,0f), 0.15F);
		//transform.rotation = new Quaternion(0f,Camera.main.transform.rotation.y,0f,0f);

		//transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);

		//transform.rotation = Quaternion.Euler (0, Camera.main.transform.eulerAngles.y, 0);

		if(Input.GetKey (KeyCode.UpArrow)){
			//rb.velocity=new Vector3(rb.velocity.x,rb.velocity.y,5f);
			transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		}
		if(Input.GetKey (KeyCode.DownArrow)){
			//rb.velocity=new Vector3(rb.velocity.x,rb.velocity.y,5f);
			transform.position = transform.position - Camera.main.transform.forward * speed * Time.deltaTime;
		}
		if(Input.GetKey (KeyCode.RightArrow)){
			//rb.velocity=new Vector3(rb.velocity.x,rb.velocity.y,5f);
			transform.Rotate(Vector3.up, Time.deltaTime*50);
		}
		if(Input.GetKey (KeyCode.LeftArrow)){
			//rb.velocity=new Vector3(rb.velocity.x,rb.velocity.y,5f);
			transform.Rotate(Vector3.up, Time.deltaTime*-50);
		}

		if (Input.GetKeyDown (KeyCode.Z)) {
			c1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Z)==false) {
			c1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.S)) {
			cs1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.S)==false) {
			cs1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.X)) {
			d1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.X)==false) {
			d1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.D)) {
			ds1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.D)==false) {
			ds1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.C)) {
			e1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.C)==false) {
			e1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.V)) {
			f1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.V)==false) {
			f1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.G)) {
			fs1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.G)==false) {
			fs1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.B)) {
			g1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.B)==false) {
			g1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.H)) {
			gs1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.H)==false) {
			gs1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.N)) {
			a1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.N)==false) {
			a1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.J)) {
			as1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.J)==false) {
			as1.GetComponent<AudioSource> ().Stop ();

		}
		if (Input.GetKeyDown (KeyCode.M)) {
			b1.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.M)==false) {
			b1.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Q)) {
			c21.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Q)==false) {
			c21.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Comma)) {
			c22.GetComponent<AudioSource> ().Play ();
		
		} else if (Input.GetKey (KeyCode.Comma)==false) {
			c22.GetComponent<AudioSource> ().Stop ();

		}



		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			cs2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Alpha2)==false) {
			cs2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.W)) {
			d2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.W)==false) {
			d2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			ds2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Alpha3)==false) {
			ds2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.E)) {
			e2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.E)==false) {
			e2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.R)) {
			f2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.R)==false) {
			f2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			fs2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Alpha5)==false) {
			fs2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.T)) {
			g2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.T)==false) {
			g2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Alpha6)) {
			gs2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Alpha6)==false) {
			gs2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Y)) {
			a2.GetComponent<AudioSource> ().Play ();
		
		} else if (Input.GetKey (KeyCode.Y)==false) {
			a2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.Alpha7)) {
			as2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.Alpha7)==false) {
			as2.GetComponent<AudioSource> ().Stop ();

		}
		if (Input.GetKeyDown (KeyCode.U)) {
			b2.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.U)==false) {
			b2.GetComponent<AudioSource> ().Stop ();

		}

		if (Input.GetKeyDown (KeyCode.I)) {
			c3.GetComponent<AudioSource> ().Play ();

		} else if (Input.GetKey (KeyCode.I)==false) {
			c3.GetComponent<AudioSource> ().Stop ();

		}

	}
}
