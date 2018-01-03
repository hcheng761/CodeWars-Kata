#include <stdlib.h>
#include <math.h>

std::string calculateString(std::string calcIt) 
{
    std::cout<<calcIt<<std::endl;
    std::string res1;
    std::string res2;
    int op; char opChar;
    if (calcIt.find("+") != std::string::npos)
      op = calcIt.find("+");
    else if (calcIt.find("-") != std::string::npos)
      op = calcIt.find("-");
    else if (calcIt.find("*") != std::string::npos)
      op = calcIt.find("*");
    else if (calcIt.find("/") != std::string::npos)
      op = calcIt.find("/");
    opChar = calcIt[op];
    
    int dec1 = calcIt.substr(0,op).find(".");
    int dec2 = calcIt.substr(op, calcIt.length() - op).find(".");

    if (dec1 != std::string::npos) {
      for (int i = 0; i < dec1; i++)
        if (isdigit(calcIt[i]))
          res1 += calcIt[i];
      res1 += ".";
      for (int i = dec1; i < op; i++)
        if (isdigit(calcIt[i]))
          res1 += calcIt[i];
    }
    else {
      for (int i = 0; i < op; i++)
        if (isdigit(calcIt[i]))
          res1 += calcIt[i];
    }
    if (dec2 != std::string::npos) {
      for (int i = op; i < dec2 + op; i++)
        if (isdigit(calcIt[i]))
          res2 += calcIt[i];
      res2 += ".";
      for (int i = dec2 + op; i < calcIt.length(); i++)
      {
        if (isdigit(calcIt[i]))
          res2 += calcIt[i];
      }
    }
    else {
      for (int i = op; i < calcIt.length(); i++)
        if (isdigit(calcIt[i]))
          res2 += calcIt[i];
    }
    double n1 = atof(res1.c_str());
    double n2 = atof(res2.c_str());

    if (opChar == '+')
      return std::to_string((int)round(n1+n2));
    else if (opChar == '-')
    {
      if (n1 > n2)
        return std::to_string((int)round(n1-n2));
      else
        return "-" + std::to_string((int)round(n2-n1));
    }
    else if (opChar == '*')
      return std::to_string((int)round(n2*n1));
    else if (opChar == '/')
      return std::to_string((int)round(n1/n2));
}   
