using UnityEngine;

public class CharController : MonoBehaviour
{
    private Animator animator;
    private int VertHash = Animator.StringToHash("Vertical");
    private int HorizHash = Animator.StringToHash("Horizontal");
    public Joystick joystick;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat(HorizHash, joystick.Horizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(VertHash, joystick.Vertical, 0.1f, Time.deltaTime);
    }
}