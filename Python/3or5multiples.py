def find(n):
    return sum(i for i in range(0,n+1) if i % 5 == 0 or i %3 == 0)
