from functools import reduce

def solution(a):
    return reduce(GCD,a)*len(a)
    
def GCD(a, b):
    if b == 0:
        return a
    else:
        return GCD(b, a % b)
