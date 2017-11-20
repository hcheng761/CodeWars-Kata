def valid_parentheses(string):
    #your code here
    stringList = []
    for i in string:
        if i=='(' or i==')':
            stringList.append(i)
            
    if len(stringList) == 0:
        return True
    if len(stringList) < 2 or stringList[-1] == '(' or stringList[0] == ')':
        return False
    
    while stringList != []:
        print(stringList)
        left = '(' in stringList
        if left == False:
            return False
        else:
            leftind = stringList.index('(')
            right = ')' in stringList[leftind:]
            if right == False:
                return False
            else:
                rightind = stringList.index(')')
                del stringList[leftind]
                del stringList[rightind-1]
    return True
