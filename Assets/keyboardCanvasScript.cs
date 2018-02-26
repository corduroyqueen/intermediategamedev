using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboardCanvasScript : MonoBehaviour {

	public GameObject keyboard;
	public bool check;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown (KeyCode.Space)){
			keyboard.GetComponent<RawImage> ().enabled = !keyboard.GetComponent<RawImage> ().enabled;
			check = !check;
		}
		if (check){
			if (Input.GetKeyDown (KeyCode.Z)) {

				GameObject.Find ("C1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Z)==false) {
				
				GameObject.Find ("C1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.S)) {
				
				GameObject.Find ("Cs1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.S)==false) {
				
				GameObject.Find ("Cs1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.X)) {
				
				GameObject.Find ("D1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.X)==false) {
				
				GameObject.Find ("D1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.D)) {
				
				GameObject.Find ("Ds1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.D)==false) {
				
				GameObject.Find ("Ds1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.C)) {
				
				GameObject.Find ("E1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.C)==false) {
				
				GameObject.Find ("E1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.V)) {
				
				GameObject.Find ("F1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.V)==false) {
		
				GameObject.Find ("F1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.G)) {

				GameObject.Find ("Fs1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.G)==false) {
				
				GameObject.Find ("Fs1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.B)) {

				GameObject.Find ("G1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.B)==false) {
				
				GameObject.Find ("G1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.H)) {
				
				GameObject.Find ("Gs1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.H)==false) {
				
				GameObject.Find ("Gs1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.N)) {

				GameObject.Find ("A1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.N)==false) {
				
				GameObject.Find ("A1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.J)) {
				
				GameObject.Find ("As1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.J)==false) {
				
				GameObject.Find ("As1image").GetComponent<RawImage> ().enabled = false;
			}
			if (Input.GetKeyDown (KeyCode.M)) {

				GameObject.Find ("B1image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.M)==false) {
				
				GameObject.Find ("B1image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Q)) {
				
				GameObject.Find ("C2image2").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Q)==false) {
				
				GameObject.Find ("C2image2").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Comma)) {
				
				GameObject.Find ("C2image1").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Comma)==false) {
				
				GameObject.Find ("C2image1").GetComponent<RawImage> ().enabled = false;
			}



			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				
				GameObject.Find ("Cs2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Alpha2)==false) {
				
				GameObject.Find ("Cs2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.W)) {
				
				GameObject.Find ("D2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.W)==false) {
				
				GameObject.Find ("D2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				
				GameObject.Find ("Ds2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Alpha3)==false) {
		
				GameObject.Find ("Ds2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.E)) {

				GameObject.Find ("E2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.E)==false) {
				
				GameObject.Find ("E2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.R)) {
				
				GameObject.Find ("F2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.R)==false) {
				
				GameObject.Find ("F2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Alpha5)) {

				GameObject.Find ("Fs2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Alpha5)==false) {
				
				GameObject.Find ("Fs2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.T)) {
				
				GameObject.Find ("G2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.T)==false) {
				
				GameObject.Find ("G2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				
				GameObject.Find ("Gs2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Alpha6)==false) {
				
				GameObject.Find ("Gs2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Y)) {
				
				GameObject.Find ("A2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Y)==false) {
				
				GameObject.Find ("A2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.Alpha7)) {

				GameObject.Find ("As2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.Alpha7)==false) {
				
				GameObject.Find ("As2image").GetComponent<RawImage> ().enabled = false;
			}
			if (Input.GetKeyDown (KeyCode.U)) {

				GameObject.Find ("B2image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.U)==false) {
				
				GameObject.Find ("B2image").GetComponent<RawImage> ().enabled = false;
			}

			if (Input.GetKeyDown (KeyCode.I)) {
				
				GameObject.Find ("C3image").GetComponent<RawImage> ().enabled = true;
			} else if (Input.GetKey (KeyCode.I)==false) {
				
				GameObject.Find ("C3image").GetComponent<RawImage> ().enabled = false;
			}


		}
	}
}
