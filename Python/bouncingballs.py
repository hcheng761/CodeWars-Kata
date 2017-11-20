def bouncingBall(h, bounce, window):
    # your code
    if h > 0 and bounce > 0 and bounce < 1 and window < h:
        cnt = 0
        while h > window:
            cnt+=1
            h *= bounce
            if h > window:
                cnt+=1
        return cnt
    else:
        return -1
