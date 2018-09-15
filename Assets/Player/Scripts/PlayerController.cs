using UnityEngine;
public class PlayerController : MonoBehaviour
{
	public Animator animator;
	void Start()
	{
		
	}
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;
		animator.SetBool("Walking",Input.GetButton("Vertical")||Input.GetButton("Horizontal"));
		animator.SetBool("Running",Input.GetButton("RunMod"));
        transform.Translate(x, 0, z);
		if(Input.GetButton("Jump"))
		{
		transform.Translate(0, 0.8f, 0);
		}
    }
}
