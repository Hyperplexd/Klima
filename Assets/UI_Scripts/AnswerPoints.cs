using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerPoints : MonoBehaviour
{
    public QuizPointsCollector pointsCollector;
    public Quiz quiz;

    int pointsToAdd;

    public void CollectPoints(int points)
    {
        pointsToAdd = points;
    }

    public void AddPoints()
    {
        if(quiz.selectedQ == true)
        {
            pointsCollector.points += pointsToAdd;
            pointsCollector.NextQuestion();
        }
    }
}
