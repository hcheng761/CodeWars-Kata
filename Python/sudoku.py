from math import sqrt

class Sudoku(object):
    #your code here
    def __init__(self,board):    
        self.board = board
        self.n = len(self.board)
        self.nsqrt = int(sqrt(self.n))
    def is_valid(self):
        for row in self.board:
            if len(row) != self.n:
                return False
            for i in row:
                if not type(i) is int:
                    return False
            if not self.validRow(row):
                return False  
        for i in range(0,self.n):
            if not self.validColumn(i):
                return False
        for i in range(0,self.n,self.nsqrt):
            if not self.validSquare(i):
                return False    
        return True
    
    def perfectSquare(self,n):
        if n == 0:
            return False
        x = n // 2
        y = set([x])
        while x * x != n:
            x = (x + (n // x)) // 2
            if x in y: return False
            y.add(x)
        return True
    
    def validColumn(self,i):
        s = set([int(item[i]) for item in self.board])  
        if len(s) != self.n:
            return False
        elif not self.rangeCheck(s):
            return False
        return True
    
    def validRow(self,i):
        s = set(i)
        if len(s) != self.n:
            return False
        elif not self.rangeCheck(s):
            return False
        return True
        
    def validSquare(self,num): #passing in row number
        list = []
        for j in range(0,self.n,self.nsqrt):
            for i in range(num,num+self.nsqrt):
                for k in range(j,j+self.nsqrt):
                    list.append(self.board[i][k])
            if len(set(list)) != self.n or not self.rangeCheck(list):
                return False
            list = []
        return True
        
    def rangeCheck(self,list):
        if all(0 < i <= self.n for i in list):
            return True
        return False
