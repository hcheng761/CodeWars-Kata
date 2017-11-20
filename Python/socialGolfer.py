def valid(a):
    lastLen = len(a[-1])
    lastSet = set(''.join(a[-1]))
    if not all(len(x) == lastLen for x in a): # all days have same number of groups
        return False
    for i in a:
        lastLen = len(i[-1])
        if not all(len(x) == lastLen for x in i): # each day has equal people per group
            return False
        elif len(''.join(i)) != len(set(''.join(i))):    # players play once a day
            return False
        elif not set(''.join(i)) == lastSet: # no new players
            return False
    flat_list = [item for i in a for item in i] # players play against each other only once
    for i in flat_list:
        for j in flat_list:
            if i==j:
                continue
            if len(set(i) & set(j)) > 1:
                return False
    return True 
