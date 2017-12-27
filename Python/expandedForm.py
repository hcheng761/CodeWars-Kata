def expanded_form(num):
    ex = ""
    list = [int(d) for d in str(num)]
    for i in range(0,len(list)):
        if list[i] != 0:
            ex += str(list[i]*(10**(len(list)-i-1))) + " + "
    return ex[:-3]
