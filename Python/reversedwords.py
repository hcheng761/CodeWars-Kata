def reverseWords(str):
    words = str.split()
    words.reverse()
    str = ' '.join(words)
    return str
