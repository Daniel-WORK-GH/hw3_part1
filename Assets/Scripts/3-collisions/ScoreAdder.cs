using TMPro;
using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] string triggeringTag;
    [SerializeField] TMP_Text scoreField;
    [SerializeField] int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && scoreField!=null) {
            GameStatusTracker.playerScore += pointsToAdd;
            scoreField.text = "Score : " + GameStatusTracker.playerScore;
        }
    }

    public ScoreAdder SetScoreTMPText(TMP_Text text){
        this.scoreField = text;
        return this;
    }

    public ScoreAdder SetPointsToAdd(int newPointsToAdd) {
        this.pointsToAdd = newPointsToAdd;
        return this;
    }
}
