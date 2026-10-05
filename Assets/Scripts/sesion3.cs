using UnityEngine;

public class sesion3 : MonoBehaviour
{

    //1. Random.Range
    
    void Start()
    {
        int fuerza = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int con = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int des = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int apariencia = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int poder = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int suerte = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;




        int tamaño = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int inteligencia = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int educacion = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;



        int edad = Random.Range(15, 90);


        if (15 <= edad && edad <= 19)
        {

            Debug.Log("Modificacion");

            fuerza -= 5;
            tamaño -= 5;
            educacion -= 5;

            //rerollea suerte

            int sureReroll = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
            if (sureReroll > suerte)
            {
                suerte = sureReroll;
            }

        }
        else if (20 <= edad && edad <= 39)
        {
            //MEJORA DE EDUCACION

            int Und100 = Random.Range(1, 101);

            if (Und100 > educacion)
            {
                Debug.Log("Has estudiado");
                educacion = educacion + Random.Range(1, 11);
            }
        }

        //2.1 Bucle While 

        int num1 = 1;
        int imp=Random.Range(1,101);
        while (num1 <= imp)
        {
            Debug.Log(num1);
            num1++;
        }


        //2.2 Bucle While 

        int numero1 = 1;
        int numero2 = 3;
        int c = 0;
        int resultado = 0;
        while (c < numero2)
        {
            resultado = resultado + numero1;
            c++;
        }









    }


    void Update()
    {
        
    }
}
