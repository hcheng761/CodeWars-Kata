def increment_string(strng):
    print(strng)
    if strng =='' or strng[-1].isdigit() == False:
        return strng + '1'
    elif strng[-1] == 0:
        strng[-1] == 1
        return strng
        
    list = []
    i = -1
    for i in range(-1, -len(strng)-1, -1):
        if strng[i].isdigit() == False:
            break
        list.insert(0,strng[i])
    num = int(''.join(map(str,list))) + 1
    
    strng = strng[:-len(list)]
    print(strng)
    if len(str(num)) < len(list):
        z = len(list) - len(str(num))
        for i in range(0,z):
            strng += '0'
    return strng + str(num)
    
    "Bj747651<\\&zM'2S635524169755298700000636238"
    "Bj747651< \\&zM'2S635524169755298700000636238"
