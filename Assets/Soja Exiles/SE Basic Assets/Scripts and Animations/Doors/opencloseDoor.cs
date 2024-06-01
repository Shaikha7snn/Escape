using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opencloseDoor: MonoBehaviour {

	public Animator openandclose;
	public bool open;
	public Transform Player;
    public AudioSource audioSource;

    void Start (){
		open = false;
	}

	void OnMouseOver (){
		{
			if (Player) {
				float dist = Vector3.Distance (Player.position, transform.position);
				if (dist < 15) {
					if (open == false) {
						if (Input.GetMouseButtonDown (0)) {
							StartCoroutine (opening ());
                            PlayAudio();

                        }
					} else {
						if (open == true) {
							if (Input.GetMouseButtonDown (0)) {
								StartCoroutine (closing ());
								PlayAudio();

                            }
						}

					}

				}
			}

		}

	}
    public void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSource is not found!");
        }
    }

    IEnumerator opening(){
		print ("you are opening the door");
		openandclose.Play ("Opening");
		open = true;
		yield return new WaitForSeconds (.5f);
	}

	IEnumerator closing(){
		print ("you are closing the door");
		openandclose.Play ("Closing");
		open = false;
		yield return new WaitForSeconds (.5f);
	}


}

