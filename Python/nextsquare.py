from math import sqrt
def find_next_square(sq):
    if not sqrt(sq).is_integer():
        return -1
    else:
        return (sqrt(sq)+1)**2
