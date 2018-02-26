using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class friendScript : MonoBehaviour {

	public bool present;

	public bool c1Pressed;
	public bool cs1Pressed;
	public bool d1Pressed;
	public bool ds1Pressed;
	public bool e1Pressed;
	public bool f1Pressed;
	public bool fs1Pressed;
	public bool g1Pressed;
	public bool gs1Pressed;
	public bool a1Pressed;
	public bool as1Pressed;
	public bool b1Pressed;
	public bool c2Pressed;
	public bool cs2Pressed;
	public bool d2Pressed;
	public bool ds2Pressed;
	public bool e2Pressed;
	public bool f2Pressed;
	public bool fs2Pressed;
	public bool g2Pressed;
	public bool gs2Pressed;
	public bool a2Pressed;
	public bool as2Pressed;
	public bool b2Pressed;
	public bool c3Pressed;

	public bool quest1;
	public bool quest2;
	public bool quest3;
	public bool quest4;
	public bool quest5;
	public bool quest6;
	public bool quest7;

	public bool cInteract;
	public bool csInteract;
	public bool dInteract;
	public bool dsInteract;
	public bool eInteract;
	public bool fInteract;
	public bool fsInteract;
	public bool gInteract;
	public bool gsInteract;
	public bool aInteract;
	public bool asInteract;
	public bool bInteract;


	public Canvas questText;




	public bool timerStart;
	public float timer;
	public int noteCount;
	public float timerWindow;

	public GameObject quest2song;

	public bool questComplete;

	public Text questTextObj;
	public Text quest6TextObj;

	public bool questEnabled;

	public bool keyCheck;

	public GameObject player;

	// Use this for initialization
	void Start () {
		timerStart = false;
		timer = 0f;
		questEnabled = true;
		player = GameObject.Find ("playerpos");
	}
	
	// Update is called once per frame
	void Update () {
		if (present) {
			questText.enabled = true;

			if (quest1) {
				if (Input.anyKeyDown) {
					keyCheck = true;
				}
				if (keyCheck) {
					if (Input.GetKeyDown (KeyCode.Z) && questEnabled && keyCheck==true) {
						c1Pressed = true;
						keyCheck = false;
					}
					if (Input.GetKeyDown (KeyCode.C) && c1Pressed && keyCheck==true) {
						e1Pressed = true;
						keyCheck = false;
					} else if (Input.GetKeyDown (KeyCode.Q) == false && Input.GetKeyDown (KeyCode.B) == false && keyCheck==true) {
						c1Pressed = false;
						e1Pressed = false;
						keyCheck = false;
					}

					if (Input.GetKeyDown (KeyCode.B) && e1Pressed && c1Pressed && keyCheck==true) {
						g1Pressed = true;
						keyCheck = false;
					} else if (Input.GetKeyDown (KeyCode.Q) == false && keyCheck==true) {
						c1Pressed = false;
						e1Pressed = false;
						keyCheck = false;
					}

					if ((Input.GetKeyDown (KeyCode.Q) || Input.GetKeyDown (KeyCode.Comma)) && e1Pressed && c1Pressed && g1Pressed && keyCheck==true) {
						c2Pressed = true;
						keyCheck = false;
					} else if (keyCheck==true) {
						c1Pressed = false;
						e1Pressed = false;
						g1Pressed = false;
						keyCheck = false;
					}

					if (c2Pressed) {
						questComplete = true;
						questTextObj.GetComponent<Text> ().text = "Good job!!!";
						questEnabled = false;

					}
				}

			}

			if (quest2) {
				
				if (Input.anyKeyDown && timerStart==false) {
					timerStart = true;
				}
				if (timerStart == true) {
					timer++;

					if (Input.GetKeyDown (KeyCode.Z) ||
					   Input.GetKeyDown (KeyCode.X) ||
					   Input.GetKeyDown (KeyCode.C) ||
					   Input.GetKeyDown (KeyCode.V) ||
					   Input.GetKeyDown (KeyCode.B) ||
					   Input.GetKeyDown (KeyCode.N) ||
					   Input.GetKeyDown (KeyCode.M) ||
					   Input.GetKeyDown (KeyCode.Q)) {

						noteCount += 1;
					}

					if (Input.GetKeyDown (KeyCode.S) ||
						Input.GetKeyDown (KeyCode.D) ||
						Input.GetKeyDown (KeyCode.G) ||
						Input.GetKeyDown (KeyCode.H) ||
						Input.GetKeyDown (KeyCode.J)) {

						noteCount -= 1;
					}

					if (timer > timerWindow && questEnabled==true) {

						if (noteCount > 35) {
							questComplete = true;
							questTextObj.GetComponent<Text> ().text = "Wow!! Amazing!";
							questEnabled = false;
						}

						if (noteCount <= 35){

						}


						timer = 0f;
						timerStart = false;
						noteCount = 0;
					}
				}


				}
			if (quest3) {

				if (Input.GetKeyDown (KeyCode.X) && questEnabled) {
					d1Pressed = true;
				}
				if (Input.GetKeyUp (KeyCode.X)) {
					d1Pressed = false;
				}	

				if (Input.GetKeyDown (KeyCode.W) && questEnabled) {
					d2Pressed = true;
				}
				if (Input.GetKeyUp (KeyCode.W)) {
					d2Pressed = false;
				}	

				if (Input.GetKeyDown (KeyCode.V)) {
					f1Pressed = true;
				}
				if (Input.GetKeyUp (KeyCode.V)) {
					f1Pressed = false;
				}	
				if (Input.GetKeyDown (KeyCode.R)) {
					f2Pressed = true;
				}
				if (Input.GetKeyUp (KeyCode.R)) {
					f2Pressed = false;
				}

				if (Input.GetKeyDown (KeyCode.N)) {
					a1Pressed = true;
				}
				if (Input.GetKeyUp (KeyCode.N)) {
					a1Pressed = false;
				}	
				if (Input.GetKeyDown (KeyCode.Y)) {
					a2Pressed = true;
				}
				if (Input.GetKeyUp (KeyCode.Y)) {
					a2Pressed = false;
				}	

				if (d1Pressed || d2Pressed) {
					dInteract = true;
				} else {
					dInteract = false;
				}


				if (f1Pressed || f2Pressed) {
					fInteract = true;
				} else {
					fInteract = false;
				}


				if (a1Pressed || a2Pressed) {
					aInteract = true;
				} else {
					aInteract = false;
				}

				if (dInteract && fInteract && aInteract) {
					questTextObj.GetComponent<Text> ().text = "Wow! That was beautiful.";
					questComplete = true;
					questEnabled = false;
				}
			}

			if (quest4) {



				if (Input.GetKeyDown (KeyCode.Z) && questEnabled) {
					c1Pressed = true;
					keyCheck = true;
				}

				if (Input.GetKeyDown (KeyCode.X) && c1Pressed) {
					d1Pressed = true;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.Z) == false && c1Pressed && d1Pressed==false  && ds1Pressed==false && f1Pressed==false && g1Pressed==false && gs1Pressed==false && as1Pressed==false) {
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.D) && d1Pressed) {
					ds1Pressed = true;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.D) == false && Input.GetKey(KeyCode.X) == false && d1Pressed && ds1Pressed==false && f1Pressed==false && g1Pressed==false && gs1Pressed==false && as1Pressed==false) {
					Debug.Log ("okay");
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.V) && ds1Pressed) {
					f1Pressed = true;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.V) == false && Input.GetKey(KeyCode.D) == false && ds1Pressed && f1Pressed==false && g1Pressed==false && gs1Pressed==false && as1Pressed==false) {
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.B) && f1Pressed) {
					g1Pressed = true;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.B) == false && Input.GetKey(KeyCode.V) == false && f1Pressed && g1Pressed==false && gs1Pressed==false && as1Pressed==false) {
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.H) && g1Pressed) {
					gs1Pressed = true;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.H) == false && Input.GetKey(KeyCode.B) == false && g1Pressed && gs1Pressed==false && as1Pressed==false) {
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.J) && gs1Pressed) {
					as1Pressed = true;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.J) == false && Input.GetKey(KeyCode.H) == false && gs1Pressed && as1Pressed==false) {
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.Comma) && as1Pressed) {
					questTextObj.GetComponent<Text> ().text = "You are incredible.";
					questComplete = true;
					questEnabled = false;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.Comma) == false  && Input.GetKey(KeyCode.Q) == false && Input.GetKey(KeyCode.J) == false && as1Pressed) {
					QuestFailure ();
				}

				if (Input.GetKeyDown (KeyCode.Q) && as1Pressed) {
					questTextObj.GetComponent<Text> ().text = "You are incredible.";
					questComplete = true;
					questEnabled = false;
				} else if (Input.anyKeyDown && Input.GetKey(KeyCode.Q) == false  && Input.GetKey(KeyCode.Comma) == false && Input.GetKey(KeyCode.J) == false && as1Pressed) {
					QuestFailure ();
				}



			}

			if (quest5) {

				if (CheckC() && CheckF() && CheckA() && keyCheck) {
					questTextObj.GetComponent<Text> ().text = "Damn! That was impressive.";
					questComplete = true;
					questEnabled = false;
				}

				if (CheckC() && CheckE() && CheckG() && questEnabled) {
					cInteract = true;
					keyCheck = true;
				}




			}

			if (quest6) {

				if (CheckF() && CheckA () && CheckC() && questComplete==false) {
					aInteract = true;
					questTextObj.GetComponent<Text> ().text = ":O!";
				}

				if (CheckF() && CheckGs() && CheckC() && questComplete==false) {
					gsInteract = true;
					quest6TextObj.GetComponent<Text> ().text = ":O!";
				}

				if (questComplete) {
					aInteract = false;
				}

				if (aInteract && gsInteract) {
					questComplete = true;
					questEnabled = false;

					questTextObj.GetComponent<Text> ().text = ":O!!!!!";
					quest6TextObj.GetComponent<Text> ().text = ":O!!!!!";

				}



			}

		} else {
			questText.enabled = false;
		}

		questText.transform.LookAt (player.transform);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "player") {
			present = true;
			if (quest2) {
				quest2song.GetComponent<AudioSource> ().Play ();
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "player") {
			present = false;
			if (quest2) {
				quest2song.GetComponent<AudioSource> ().Stop ();
			}
		}
	}

	void QuestFailure(){
		c1Pressed = false;
		cs1Pressed = false;
		d1Pressed = false;
		ds1Pressed = false;
		e1Pressed = false;
		f1Pressed = false;
		fs1Pressed = false;
		g1Pressed = false;
		gs1Pressed = false;
		a1Pressed = false;
		as1Pressed = false;
		b1Pressed = false;
		c2Pressed = false;
		cs2Pressed = false;
		d2Pressed = false;
		ds2Pressed = false;
		e2Pressed = false;
		f2Pressed = false;
		fs2Pressed = false;
		g2Pressed = false;
		gs2Pressed = false;
		a2Pressed = false;
		as2Pressed = false;
		b2Pressed = false;
		c3Pressed = false;
	}

	public bool CheckC(){
		if (Input.GetKeyDown (KeyCode.Z)) {
			c1Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.Z)) {
			c1Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.Q)) {
			c2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.Q) && Input.GetKey(KeyCode.Comma)==false) {
			c2Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.Comma)) {
			c2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.Comma) && Input.GetKey(KeyCode.Q)==false) {
			c2Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.I)) {
			c3Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.I)) {
			c3Pressed = false;
		}	

		if (c1Pressed || c2Pressed || c3Pressed) {
			return true;
		} else {
			return false;
		}
	}

	public bool CheckE(){
		if (Input.GetKeyDown (KeyCode.C)) {
			e1Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.C) && Input.GetKey (KeyCode.E)==false) {
			e1Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.E)) {
			e2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.E) && Input.GetKey (KeyCode.C)==false) {
			e2Pressed = false;
		}	
		if (e1Pressed || e2Pressed) {
			return true;
		}else {
			return false;
		}
	}

	public bool CheckG(){
		if (Input.GetKeyDown (KeyCode.B)) {
			g1Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.B) && Input.GetKey (KeyCode.T)==false) {
			g1Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.T)) {
			g2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.T) && Input.GetKey (KeyCode.B)==false) {
			g2Pressed = false;
		}	

		if (g1Pressed || g2Pressed) {
			return true;
		}else {
			return false;
		}
	}

	public bool CheckF(){
		if (Input.GetKeyDown (KeyCode.V)) {
			f1Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.V) && Input.GetKey (KeyCode.R)==false) {
			f1Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.R)) {
			f2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.R) && Input.GetKey (KeyCode.V)==false) {
			f2Pressed = false;
		}	

		if (f1Pressed || f2Pressed) {
			return true;
		}else {
			return false;
		}
	}

	public bool CheckA(){
		if (Input.GetKeyDown (KeyCode.N)) {
			a1Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.N) && Input.GetKey (KeyCode.Y)==false) {
			a1Pressed = false;
		}	

		if (Input.GetKeyDown (KeyCode.Y)) {
			a2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.Y) && Input.GetKey (KeyCode.N)==false) {
			a2Pressed = false;
		}	

		if (a1Pressed || a2Pressed) {
			return true;
		}else {
			return false;
		}
	}

	public bool CheckGs(){
		
		if (Input.GetKeyDown (KeyCode.H)) {
			gs1Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.H) && Input.GetKey (KeyCode.Alpha6)==false) {
			gs1Pressed = false;
		}	
		
		if (Input.GetKeyDown (KeyCode.Alpha6)) {
			gs2Pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.Alpha6) && Input.GetKey (KeyCode.H)==false) {
			gs2Pressed = false;
		}	
		
		if (gs1Pressed || gs2Pressed) {
			return true;
		} else {
			return false;
		}
	}


}
