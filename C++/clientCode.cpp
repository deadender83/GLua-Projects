#include "phoneList.h"

using namespace std;

int main() {
    PhoneList phoneList("Contacts");

    phoneList.addDirectory("Rob", 123, 4567890);
    phoneList.addDirectory("Bob", 456, 1234567);
    phoneList.addDirectory("Todd", 789, 9876543);

    phoneList.showPhoneList(cout);

    phoneList.removeDirectory("Bob");
    phoneList.showPhoneList(cout);

    phoneList.removeDirectory("Toad");
    phoneList.showPhoneList(cout);
}