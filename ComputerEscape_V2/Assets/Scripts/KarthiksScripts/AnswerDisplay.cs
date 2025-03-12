using UnityEngine;
using TMPro;

public class AnswerDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text answerText;

    private Vector3 startPos;
    private float floatSpeed = 1.5f;
    private float floatHeight = 0.5f;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        // Move the cube up and down smoothly
        transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time * floatSpeed) * floatHeight, 0);
    }

    public void SetAnswerText(string answer)
    {
        answerText.text = answer;
    }

    public string GetAnswerText()
    {
        return answerText.text;
    }
}
