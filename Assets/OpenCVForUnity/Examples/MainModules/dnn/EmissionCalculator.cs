using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenCVForUnityExample
{
    public class EmissionCalculator : MonoBehaviour
    {
        public float carbonLvl;
        public int numOfChanges;
        public float carbonPercent;

        void Update()
        {

        }

        public void GetPercentage()
        {
            carbonPercent = (carbonLvl * 100) / numOfChanges;
            print(carbonPercent);
        }

        public void Decrease(float value)
        {
            carbonLvl -= value;
            numOfChanges++;
        }

        public void Increase(float value)
        {
            carbonLvl += value;
            numOfChanges++;
        }
    }
}

