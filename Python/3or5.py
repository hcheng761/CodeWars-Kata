def solution(number):
    identicals = []
    ff = 0
    while (ff < number):
        identicals.append(ff)
        ff += 15
        
    t = 1
    f = 1
    threes = []
    fives = []
    
    while t*3 < number:
        threes.append(t*3)
        t+=1
    while f*5 < number:
        fives.append(f*5)
        f+=1
    
    print(threes)
    print(fives)
    print("This number:",number)
    sum = 0
    for i in threes:
        sum+=i
    for i in fives:
        sum+=i
    
    for i in identicals:
        sum-=i
    return sum
