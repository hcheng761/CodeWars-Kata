import math

def last_digit(lst):
    if lst == []:
        return 1
    pwr = lst[-1]
    zeroCheck = 0
    for i in range (len(lst)-1,0,-1):
        total = lst[i-1]
        temp = lst[i-1]
        if pwr == 0 and zeroCheck == 0:
            total = 1
        elif temp == 0:
            total = 0
        elif pwr == 0 and zeroCheck != 0:
            total = evalPower(temp)
        else:
            pwr = checkZero(pwr%1000)
            total = checkZero(total%1000)
            for j in range(0,pwr-1):
                total = ((temp%1000)*(total%1000))%100
        pwr = total
        zeroCheck = lst[i-1]
    return pwr%10
    
def evalPower(base):
    pwrs = [0,1,6,1,6,5,6,1,6,1]
    return pwrs[base%10]

def checkZero(total):
    lst = [int(d) for d in str(total)]
    lst2 = []
    for i in lst:
        if i != 0:
            lst2.append(i)
    return int(''.join(str(digit) for digit in lst2))
