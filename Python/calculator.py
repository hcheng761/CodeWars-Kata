class Calculator(object): 
    def evaluate(self, string):
        result = eval(string)
        print(result)
        if str(result)[-1] != 0:
            return round(result, 3)
        #else:
        return int(result)
