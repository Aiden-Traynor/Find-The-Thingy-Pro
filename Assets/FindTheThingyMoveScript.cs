using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheThingyMoveScript : MonoBehaviour
{
  public float Speed;
  public float RotationSpeed;
  Rigidbody R;
  public float JumpHeight;
  bool jumping = false;
  Animator AV;
  float sC;
  int Gold = 0;
  AudioSource ASV;
  float walkPitch = 1f; /* change the 1 to your walk pitch value, keep the ‘f’ at the end */
  float runPitch = 1f; /* change the 1 to your run pitch value, keep the ‘f’ at the end */
  float slowPitch = 1f; /*change the 1 to your slow walk pitch value, keep the ‘f’  at the end */
    // Start is called before the first frame update
    void Start()
    {

      Speed = 14f;
      AV = GetComponent<Animator>();
      RotationSpeed = 130f;
      R = GetComponent<Rigidbody>();
      JumpHeight = 250f;
      sC = 2f;
      ASV = GetComponent<AudioSource>();
      ASV.pitch = walkPitch;







    }

    // Update is called once per frame
    void Update()
    {


      if (Input.GetKey(KeyCode.UpArrow)){
          //move forward line
          R.MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
          AV.SetBool("Walk", true);
          if (!ASV.isPlaying)
                    	{
                        		ASV.Play();
                    	}

        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            //move back line
            R.MovePosition(transform.position - transform.forward * Speed * Time.deltaTime);
            AV.SetBool("Walk", true);
            if (!ASV.isPlaying)
            {
                  ASV.Play();
            }

          }
          else {
AV.SetBool("Walk", false);
if (ASV.isPlaying)
            	{
                		ASV.Stop();
            	}

}

      if (Input.GetKey(KeyCode.LeftArrow)) {
          //rotate left line
          transform.Rotate(-Vector3.up * RotationSpeed * Time.deltaTime); /* note the minus sign */
      }
      else if (Input.GetKey(KeyCode.RightArrow)) {
          //rotate right line
          transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (!jumping && Input.GetKey(KeyCode.Space)){
            //move forward line
            R.AddForce( Vector3.up * JumpHeight );
	jumping = true;



        }
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag.Equals("Gold")) {
        Gold = Gold + 1;
        Destroy(other.gameObject);
    }
      else if(other.gameObject.tag.Equals("Boost")) {
	       Speed = Speed * sC;
         AV.SetBool("Fast", true);
         StartCoroutine(SpeedUpCoroutine());
         Destroy(other.gameObject);
         }
  else if(other.gameObject.tag.Equals("SlowTag")) {
	     Speed = Speed / sC;
       AV.SetBool("Slow", true);
        StartCoroutine(SlowDownCoroutine());
        Destroy(other.gameObject);

 }


    }
    IEnumerator SpeedUpCoroutine()
    {
      ASV.pitch = runPitch; /* make sure this comes before the yield return statement */
        yield return new WaitForSeconds(5f);
        AV.SetBool("Fast", false);
        Speed = Speed / sC;
        ASV.pitch = walkPitch;


    }
    IEnumerator SlowDownCoroutine()
    {
      ASV.pitch = slowPitch; /* make sure this comes before the yield return statement */

        yield return new WaitForSeconds(5f);
        AV.SetBool("Slow", false);
        Speed = Speed * sC;
        ASV.pitch = walkPitch;


    }
    void OnCollisionEnter(Collision other)
{
		if(other.collider.tag.Equals("Ground")) //if we hit the floor, we are no longer jumping
{
	jumping = false;
		}
	}
 }
