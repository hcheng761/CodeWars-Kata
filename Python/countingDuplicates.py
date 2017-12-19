import collections

def duplicate_count(text):
    d = collections.defaultdict(int)
    for c in text.lower():
        d[c] += 1

    count = 0
    for i in d:
        if d[i] > 1:
            count = count + 1
    return count
