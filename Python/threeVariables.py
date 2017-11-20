import numpy as np

def solve_eq(eq):
    result = [[a[-1]] for a in eq]
    for i in eq:
        del i[-1]
    A = np.matrix(eq)
    B = np.matrix(result)
    x = np.linalg.solve(A,B)
    return [round(i[0],0) for i in x.tolist()]
