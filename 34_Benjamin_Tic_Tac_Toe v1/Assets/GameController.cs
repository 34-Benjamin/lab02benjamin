using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Cube0;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject Cube6;
    public GameObject Cube7;
    public GameObject Cube8;



    private int turnCounter;



    // Start is called before the first frame update
    void Start()
    {
        Cube0.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube1.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube2.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube3.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube4.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube5.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube6.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube7.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube8.GetComponent<MeshRenderer>().material.color = Color.white;












    }

    // Update is called once per frame
    void Update()
    {  // Getting user input//
       // 1st row of inputs//
        if (Input.GetKeyDown(KeyCode.Q))
        {
           //check if cube is white color//
           if (Cube0.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number//
                if (turnCounter % 2 == 0)
                {
                    //change color to red//
                    Cube0.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {

                    Cube0.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }
           

            
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            //check if cube is white color//
            if (Cube1.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube1.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube1.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }

      
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            //check if cube is white color//
            if (Cube2.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube2.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube2.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }
               
        }
        //2nd row of inputs//

        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (Cube3.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube3.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube3.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }

           
        }


        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (Cube4.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube4.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube4.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();

            }
              

        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (Cube5.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube5.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube5.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }
               
        }
        //3rd row of inputs//
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            if (Cube6.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube6.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube6.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }
               
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            if (Cube7.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube7.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube7.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }
              
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (Cube8.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    Cube8.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    Cube8.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                turnCounter++;

                //check for win//
                CheckRedWinCondition();
                CheckGreenWinCondition();
            }
               
        }

    
    }

    private void CheckRedWinCondition()
        // Horizontal win condition//
    {
        if(Cube0.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube2.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }

        else if (Cube3.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube5.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }


        else if (Cube6.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube7.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }



        // vertical win condition//
        if (Cube0.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube3.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube6.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }

        else if (Cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube7.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }


        else if (Cube2.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube5.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }

        //Diagonal win condiion//
        if (Cube0.GetComponent<MeshRenderer>().material.color == Color.red &&
           Cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
           Cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }

        else if (Cube6.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
                 Cube2.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Win the game!");
        }
    }

    private void CheckGreenWinCondition()
    // Horizontal win condition//
    {
        if (Cube0.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube1.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube2.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }

        else if (Cube3.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube4.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube5.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }


        else if (Cube6.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube7.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube8.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }



        // vertical win condition//
        if (Cube0.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube3.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube6.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }

        else if (Cube1.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube4.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube7.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }


        else if (Cube2.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube5.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube8.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }

        //Diagonal win condiion//
        if (Cube0.GetComponent<MeshRenderer>().material.color == Color.green &&
           Cube4.GetComponent<MeshRenderer>().material.color == Color.green &&
           Cube8.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }

        else if (Cube6.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube4.GetComponent<MeshRenderer>().material.color == Color.green &&
                 Cube2.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green Player Win the game!");
        }
    }
}
