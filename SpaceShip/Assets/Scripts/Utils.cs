using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{ 
    public static class Utils
    {
        private static float randomNumber1;
        private static float randomNumber2;

        public static Vector3 ChangePosition(Vector3 v)
        {
            float x;
            float y;

            // Random number 1
            Random.seed = System.DateTime.Now.Millisecond;
            float random1 = Random.Range(-1.0f, 1.0f);
            randomNumber1 = FloorAndCeil(random1);


            // Random number 2
            Random.seed = System.DateTime.Now.Millisecond;
            float random2 = Random.Range(-1.0f, 1.0f);
            randomNumber2 = FloorAndCeil(random2);

            x = v[0] * randomNumber1;            
            y = v[1] * randomNumber2;

            //Debug.Log(x);
            //Debug.Log(y);
            //Debug.Log(v);
            return new Vector3(x, y, v.z);
        }

        public static float FloorAndCeil(float floatNumber)
        {
            float intNumber;
            if (floatNumber <= 0)
            {
                intNumber = -1;
            }
            else
            {
                intNumber = 1;
            }
            return intNumber;
        }

    }
}
