def is_triangle(a, b, c):
    l = [a,b,c]
    l.remove(max(l))
    if sum(i for i in l) > max(a,b,c):
        return True
    return False
