def isValidWalk(walk):
    if len(walk) < 10:
        return False
    else:
        updown = 0
        leftright = 0
        
        for i in walk:
            if i=='n':
                updown+=1
            elif i=='s':
                updown-=1
            elif i=='w':
                leftright+=1
            elif i=='e':
                leftright-=1
        if updown==0 and leftright==0:
            return True
        else:
            return False
    pass
