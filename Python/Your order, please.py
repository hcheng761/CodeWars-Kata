def order(sentence):
    # code here
    words = sentence.split()
    numList = []

    for i in words:
        for j in i:
            if j.isdigit():
               numList.append(int(j))
    sort = [x for _,x in sorted(zip(numList, words))]
    sentence = ' '.join(sort)
    return sentence
