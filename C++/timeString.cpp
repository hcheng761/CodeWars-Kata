#include <sstream>
#include <iomanip>
#include <string>

std::string correct (const std::string& timeString)
{
    std::istringstream in (timeString);
    int hours = -1;
    int minutes = -1;
    int seconds = -1;

    bool wrong_delimiter = false;
    in >> hours;
    wrong_delimiter |= (in.get() != ':');
    in >> minutes;
    wrong_delimiter |= (in.get() != ':');
    in >> seconds;

    if (in.fail() || wrong_delimiter)
    {
        return "";
    }

    else
    {
        minutes += seconds / 60;
        seconds %= 60;
        hours += minutes / 60;
        minutes %= 60;
        hours %= 24;
        std::ostringstream out;
        out << std::setfill ('0') << std::setw (2) << hours << ':'
            << std::setw (2) << minutes << ':' << std::setw (2) << seconds;
        return out.str();
    }
}
