#include <string>
#include <iostream>
#include <iomanip>
#include <cassert>

using namespace std;

struct Directory {
    string name;
    int areaCode;
    int phoneNumber;
    Directory* link;
};

class PhoneList {
public:
    PhoneList(string /*name*/);
    ~PhoneList();
    void showPhoneList(ostream& /*output*/);
    void addDirectory(string /*name*/, int /*area code*/, int /*phonenumber*/);
    void removeDirectory(string /*name*/);
    inline int getDirectories() const { return numOfDirectories; }
    inline string getTitle() const { return title; }

private:
    Directory* firstPtr;
    string title;
    int numOfDirectories;
};
