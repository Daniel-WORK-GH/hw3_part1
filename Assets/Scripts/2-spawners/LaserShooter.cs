using TMPro;
using UnityEngine;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "scoreText" field of the new laser.
 */
public class LaserShooter: ClickSpawner 
{
    [SerializeField]
    [Tooltip("How many points to add to the shooter, if the laser hits its target")]
    int pointsToAdd = 1;

    // A reference to the TEXT that holds the score that has to be updated when the laser hits its target.
    [Tooltip("Score text")]
    public TMP_Text scoreText;  

    private void Start() 
    {

    }

    protected override GameObject spawnObject() 
    {
        GameObject newObject = base.spawnObject();  // base = super

        // Modify the text field of the new object.
        ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();
        if (newObjectScoreAdder)
        {
            newObjectScoreAdder.SetScoreTMPText(scoreText).SetPointsToAdd(pointsToAdd);
        }
        return newObject;
    }
}
