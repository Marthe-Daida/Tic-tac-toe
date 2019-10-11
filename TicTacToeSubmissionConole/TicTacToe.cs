using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;
using System.Threading;


namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        private char[] boardPositions = new char[9];

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(20, 5);
            _boardRenderer.Render();
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }

        private bool CheckWinner(char charToCheck)
        {
            // ROW 0
            if ((boardPositions[0] == charToCheck) && (boardPositions[1] == charToCheck) && (boardPositions[2] == charToCheck))
                return true;

            // COLUMN 1
            if ((boardPositions[1] == charToCheck) && (boardPositions[4] == charToCheck) && (boardPositions[7] == charToCheck))
                return true;

            //COLOMN 0
            if ((boardPositions[0] == charToCheck) && (boardPositions[3] == charToCheck) && (boardPositions[6] == charToCheck))
                return true;


            //COLUMN 2
            if ((boardPositions[2] == charToCheck) && (boardPositions[5] == charToCheck) && (boardPositions[8] == charToCheck))
                return true;

            //ROW 1
            if ((boardPositions[3] == charToCheck) && (boardPositions[4] == charToCheck) && (boardPositions[5] == charToCheck))
                return true;


            //ROW 2
            if ((boardPositions[6] == charToCheck) && (boardPositions[7] == charToCheck) && (boardPositions[8] == charToCheck))
                return true;

            //CROSS 1
            if ((boardPositions[0] == charToCheck) && (boardPositions[4] == charToCheck) && (boardPositions[8] == charToCheck))
                return true;

            //CROSS 2
            if ((boardPositions[2] == charToCheck) && (boardPositions[4] == charToCheck) && (boardPositions[6] == charToCheck))
                return true;




            return false;
        }

         

            

         
            }




            public void Run()
            {

                bool checkXIsWinner = CheckWinner('X');
                bool checkOIsWinner = CheckWinner('O');

             


                // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

                Console.SetCursorPosition(2, 19);

                Console.Write("Player X");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();



                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            }
        }

    }
            



       