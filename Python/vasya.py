def tickets(people):
    v25 = 0
    v50 = 0
    for i in range(0,len(people)):
        if people[i] == 25:
            v25 = v25 + 1
        elif people[i] == 50:
            v25 = v25 - 1
            v50 = v50 + 1
        elif people[i] == 100:
            if v50 == 0 and v25 >= 3:
                v25 = v25 - 3
            else:
                v25 = v25 - 1
                v50 = v50 - 1
        if v25 < 0 or v50 < 0:
           return 'NO'
    return 'YES'
