def whoIsNext(names, r):
    if r <= 5:
        return names[r-1]
    i=0
    while ((2**i)*10)-5 < r: #find max
        i+=1
    k=0
    for j in range((2**(i-1)*10)-5, (2**i*10)-5, 2**i):
        if j > r:
            break;
        k+=1
    return names[k-1]
