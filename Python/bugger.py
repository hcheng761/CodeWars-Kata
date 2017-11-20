def persistence(n):
    # your code
    cnt = n
    result = 1
    mult = 0
    while cnt/10 >= 1:
        numbers = [int(d) for d in str(cnt)]
        for i in numbers:
            result *= i 
            cnt = result
        mult+=1
        result = 1
    return mult
