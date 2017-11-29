using System;

namespace CodeWars
{
    class Connect4
    {
        int[][]board = new int[7][];
        bool player = false;
        int turns = 0;
        bool gameOver = false;
        
        public string play(int col)
        {
          if (turns == 0)      
            for (int i = 0; i < 7; i++)
              board[i] = new int[6];
          else if (gameOver == true)
            return "Game has finished!";
          
          int spot = Array.IndexOf(board[col],0);
          if (spot == -1)
            return "Column full!";
          else {
            if (player == false)    
              board[col][spot] = 1;
            else
              board[col][spot] = 2;
          }
          return eval();
        }
        public string eval()
        {
          for (int i = 0; i < 6; i++)    //check horizontal wins
            for (int j = 0; j < 4; j++)  
              if ((board[j][i] != 0) && board[j][i]==board[j+1][i] && board[j][i]==board[j+2][i] && board[j][i]==board[j+3][i])
              {
                if (player == false)
                {
                  gameOver = true;
                  return "Player 1 wins!";
                }
                else
                {
                  gameOver = true;
                  return "Player 2 wins!";
                }
              }
          
          for (int j = 0; j < 7; j++)  //check vertical wins
            for (int i = 0; i < 3; i++)
              if ((board[j][i] != 0) && board[j][i]==board[j][i+1] && board[j][i]==board[j][i+2] && board[j][i]==board[j][i+3])
              {
                if (player == false)
                {
                  gameOver = true;
                  return "Player 1 wins!";
                }
                else
                {
                  gameOver = true;
                  return "Player 2 wins!";
                }
              }
          
          for (int i = 0; i < 4; i++)
            for (int j = 0; j < 3; j++)
              if (board[i][j] != 0 && board[i][j] == board[i+1][j+1] && board[i][j] == board[i+2][j+2] && board[i][j] == board[i+3][j+3])
              {
                if (player == false) {
                  gameOver = true;
                  return "Player 1 wins!";
                }
                else {
                  gameOver = true;
                  return "Player 2 wins!";   
                }  
              }
          for (int i = 0; i < 4; i++)
            for (int j = 6; j < 3; j--)
              if (board[i][j] != 0 && board[i][j] == board[i+1][j-1] && board[i][j] == board[i+2][j-2] && board[i][j] == board[i+3][j-3])
              {
                if (player == false)
                {
                  gameOver = true;
                  return "Player 1 wins!";
                }
                else
                {
                  gameOver = true;
                  return "Player 2 wins!"; 
                }
              }
          if (player == false)
          {
            player = true;
            turns++;
            return "Player 1 has a turn";
          }
          else if (player == true)
          {
            player = false;
            turns++;
            return "Player 2 has a turn";
          }
          return " ";
        }
    }
}
