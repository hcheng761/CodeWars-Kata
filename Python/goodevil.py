def goodVsEvil(good, evil):
    #TODO Go get'em boys...
    goodList = [int(s) for s in good.split()]
    badList = [int(s) for s in evil.split()]
    
    goodTotal = 0
    badTotal = 0
    
    for i in range(0,6):
        if i == 0:
            goodTotal = goodTotal + (goodList[i]*1)
        elif i == 1:
            goodTotal = goodTotal + (goodList[i]*2)
        elif i == 2 or i == 3:
            goodTotal = goodTotal + (goodList[i]*3)
        elif i == 4:
            goodTotal = goodTotal + (goodList[i]*4)
        elif i == 5:
            goodTotal = goodTotal + (goodList[i]*10)
    
    for i in range(0,7):
        if i == 0:
            badTotal = badTotal + (badList[i]*1)
        elif i == 1 or i == 2 or i == 3:
            badTotal = badTotal + (badList[i]*2)
        elif i == 4:
            badTotal = badTotal + (badList[i]*3)
        elif i == 5:
            badTotal = badTotal + (badList[i]*5)
        elif i == 6:
            badTotal = badTotal + (badList[i]*10)
            
    if badTotal > goodTotal:
        return 'Battle Result: Evil eradicates all trace of Good'
    elif badTotal < goodTotal:
        return 'Battle Result: Good triumphs over Evil'
    else:
        return 'Battle Result: No victor on this battle field'
