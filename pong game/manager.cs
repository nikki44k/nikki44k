using UnityEngine;
using TMPro;

public class manager : MonoBehaviour
{
    [SerializeField] private TMP_Text p1_scoreText;
    [SerializeField] private TMP_Text p2_scoreText;

    [SerializeField] private Transform p1Transform;
    [SerializeField] private Transform p2Transform;
    [SerializeField] private Transform ballTransform;

    private int p1_score;
    private int p2_score;

    private static manager instance;
    public static manager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<manager>();
            }
            return instance;
        }
    }

    public void p1Scored() {
        p1_score++;
        p1_scoreText.text = p1_score.ToString();
    }
    public void p2Scored()
    {
        p2_score++;
        p2_scoreText.text = p2_score.ToString();
    }

    public void Restart() {
        p1Transform.position = new Vector2(p1Transform.position.x, 0);
        p2Transform.position = new Vector2(p2Transform.position.x, 0);
        ballTransform.position = new Vector2(0, 0);
    }


}
