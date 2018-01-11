def square_digits(num):
    list = []
    for i in str(num):
        list.append(int(i)*int(i))
    return int(''.join(str(x) for x in list))
