def maskify(cc):
    if len(cc) <= 4:
        return cc
    else:
        mask = ''
        for i in range(0, len(cc)-4):
            mask += '#'
        for i in cc[len(cc)-4:]:
            mask += i
        return mask
