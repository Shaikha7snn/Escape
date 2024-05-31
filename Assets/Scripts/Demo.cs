
using UnityEngine;

public class Demo : MonoBehaviour
{
    [SerializeField] Timer timer1;
    [SerializeField] LevelManager levelManager;

    // Start is called before the first frame update
    private void Start()
    {
        timer1.SetDuration(120).Begin();
        levelManager.timer = timer1; // Ensure the LevelManager knows about the timer
    }
}
