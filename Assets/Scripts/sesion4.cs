using UnityEngine;

public class sesion4 : MonoBehaviour
{
    
    void Start()
    {

        //1. Bucle For

        int r = 0; 

        for (int i = 1; i <= 6; i++)
        {
            r = r + i;
        }
        Debug.Log(r);

        //1.2 Bucle For 

        int initial_time = 10;

        for (int i = 10; i > 0; i--)
        {
            initial_time = initial_time - i;
            Debug.Log("EXPLOSION" + initial_time);
        }


        //1.3 Bucle For

         

        for(int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {           
                Debug.Log(i); 
            }

        }





        //1.4 Bucle For

        int mCaras = 6;
        int mDados = 3;
        int mTiradas = 100;

        int[] tiradas = new int[mDados* mTiradas+1];
        for (int i = 0; i < mTiradas; i++)
        {
            int sumaResultado = 0;
            for (int j = 0; j < mDados; j++)
            {
                sumaResultado += Random.Range(1, mCaras+1);
            }
            tiradas[sumaResultado]++;
        }


























    }


    void Update()
    {
        
    }
}
