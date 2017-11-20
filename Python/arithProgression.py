import math

def find_missing(sequence):
    dif = int(math.floor((sequence[-1]-sequence[0])/len(sequence)))
    sum = ((len(sequence)+1)*(sequence[0]+sequence[-1]))/2
    arith = 0
    for i in sequence:
        arith = arith + i
    return sum - arith
