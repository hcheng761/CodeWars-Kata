def capitals(word):
    list = []
    for i in range(0,len(word)):
        if word[i].isupper():
            list.append(i)
    return list
