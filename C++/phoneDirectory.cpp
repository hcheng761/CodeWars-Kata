#include <string>

namespace PhoneDir
{

static std::string phone(const std::string &orgdr, std::string num)
{
    std::string contact, name, address;
    std::size_t found, first;
    std::string numStr = "+" + num;
    std::string notAllowed = "$+_=;:,*/|~!?{}[]()";

    found = orgdr.find(numStr);
    first = found;

    if (found == std::string::npos)
        return "Error => Not found: " + num;
    found = orgdr.find(numStr, found + 1); 

    if (found != std::string::npos)
        return "Error => Too many people: " + num;

    found = orgdr.find("\n", first + 1);
    contact = orgdr.substr(0, found);
    found = contact.rfind("\n");
    if (found != std::string::npos)
        contact = contact.substr(found);
    name = contact.substr(contact.find("<") + 1,contact.find(">") - contact.find("<") - 1);
    contact.erase(contact.find(name) - 1, name.size() + 2);
    contact.erase(contact.find(num), num.size());

    for (char& c : contact)
        if (notAllowed.find(c) != std::string::npos || c == '\n')
            c = ' ';

    std::string::iterator it = std::unique(contact.begin(), contact.end(),
            [=](char c1, char c2) { return (c1 == c2) && (c1 == ' ');});
    contact.erase(it, contact.end());

    address = contact.substr(contact.find_first_not_of(" "),
            contact.find_last_not_of(" ") - contact.find_first_not_of(" ") + 1);

    return "Phone => " + num + ", Name => " + name + ", Address => " + address;
}

};
